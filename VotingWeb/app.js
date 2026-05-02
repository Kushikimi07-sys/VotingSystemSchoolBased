const API = "http://localhost:5194/api/";

// ===== LOGIN =====
async function login(){
  const inputRole = (document.getElementById("role").value || "").toLowerCase().trim();
  const username  = document.getElementById("username").value.trim();
  const password  = document.getElementById("password").value.trim();

  console.log("INPUT:", { username, password, inputRole });

  if(!username || !password){
    alert("Fill all fields");
    return;
  }

  try{
    const res = await fetch("http://localhost:5194/api/auth/login",{
      method:"POST",
      headers:{"Content-Type":"application/json"},
      body: JSON.stringify({username, password})
    });

    console.log("STATUS:", res.status);

    const text = await res.text();     // ← basahon nato raw response
    console.log("RAW:", text);

    if(res.status !== 200){
      alert("Login failed (check console)");
      return;
    }

    let user;
    try{
      user = JSON.parse(text);
    }catch(e){
      console.error("JSON PARSE ERROR:", e);
      alert("Invalid server response");
      return;
    }

    console.log("USER:", user);

    const dbRole = (user.role || "").toLowerCase().trim();
    console.log("COMPARE:", { inputRole, dbRole });

    if(dbRole !== inputRole){
      alert("Wrong role selected");
      return;
    }

    localStorage.setItem("user", JSON.stringify(user));

    if(dbRole === "admin"){
      console.log("GO → admin.html");
      window.location.href = "admin.html";
    }else{
      console.log("GO → voter.html");
      window.location.href = "voter.html";
    }

  }catch(e){
    console.error("FETCH ERROR:", e);
    alert("Cannot connect to API");
  }
}

// ===== REGISTER =====
function toggleRegister(){
  const box = document.getElementById("registerBox");
  box.style.display = box.style.display === "none" ? "block" : "none";
}

async function register(){
  const username = document.getElementById("regUsername").value.trim();
  const password = document.getElementById("regPassword").value.trim();
  const role = document.getElementById("regRole").value;

  if(!username || !password){
    alert("Fill all fields");
    return;
  }

  const res = await fetch(API+"auth/register",{
    method:"POST",
    headers:{"Content-Type":"application/json"},
    body: JSON.stringify({
      username,
      password,
      role   // 🔥 SEND ROLE
    })
  });

  if(res.status !== 200){
    alert("Registration failed");
    return;
  }

  alert("Registered successfully!");
  toggleRegister();
}

// ===== LOGOUT =====
function logout(){
  localStorage.removeItem("user");
  window.location = "login.html";
}

// ===== AUTH =====
function requireAuth(){
  const u = localStorage.getItem("user");
  if(!u) window.location = "login.html";
  return JSON.parse(u);
}

// ===== ADMIN =====
async function adminInit(){
  const u = requireAuth();

  if(u.role !== "admin"){
    window.location="login.html";
    return;
  }

  await loadDropdowns(); // 🔥 CRITICAL
}
// ===== LOAD DROPDOWNS =====
async function loadDropdowns(){
  try{
    const [teamsRes, posRes] = await Promise.all([
      fetch(API + "team"),
      fetch(API + "position")
    ]);

    const teams = await teamsRes.json();
    const positions = await posRes.json();

    const teamSel = document.getElementById("team");
    const posSel = document.getElementById("position");

    if(!teamSel || !posSel){
      console.error("Dropdown elements not found");
      return;
    }

    teamSel.innerHTML = "";
    posSel.innerHTML = "";

    teams.forEach(t=>{
      teamSel.innerHTML += `<option value="${t.id}">${t.name}</option>`;
    });

    positions.forEach(p=>{
      posSel.innerHTML += `<option value="${p.id}">${p.name}</option>`;
    });

  }catch(e){
    console.error("LOAD DROPDOWN ERROR:", e);
  }
}

// ===== VOTER =====
let votes = {};

async function voterInit(){
  const res = await fetch(API+"candidate");
  const data = await res.json();

  const box = document.getElementById("candidates");

  const grouped = {};
  data.forEach(c=>{
    if(!grouped[c.positionId]) grouped[c.positionId]=[];
    grouped[c.positionId].push(c);
  });

  box.innerHTML="";

  Object.keys(grouped).forEach(pos=>{
    box.innerHTML += `
      <div class="ballot">
        <h3>Position ${pos}</h3>
        ${grouped[pos].map(c=>`
          <label>
            <input type="radio" name="pos_${pos}" onclick="votes[${pos}] = ${c.id}">
            ${c.name}
          </label><br>
        `).join("")}
      </div>
    `;
  });
}

// ===== SUBMIT =====
async function submitVotes(){
  const user = requireAuth();

  for(const pos in votes){
    await fetch(API+"vote",{
      method:"POST",
      headers:{"Content-Type":"application/json"},
      body: JSON.stringify({
        userId:user.id,
        positionId:Number(pos),
        candidateId:votes[pos]
      })
    });
  }

  alert("Vote submitted!");
}

// ===== ADD TEAM =====
async function addTeam(){
  const name = document.getElementById("teamName").value.trim();

  if(!name){
    alert("Enter team name");
    return;
  }

  await fetch(API+"team",{
    method:"POST",
    headers:{
      "Content-Type":"application/json",
      "role":"admin"   // 🔥 IMPORTANT HEADER
    },
    body: JSON.stringify({name})
  });

  alert("Team added");
  loadDropdowns();
}

// ===== ADD POSITION =====
async function addPosition(){
  const name = document.getElementById("positionName").value.trim();

  if(!name){
    alert("Enter position");
    return;
  }

  await fetch(API+"position",{
    method:"POST",
    headers:{
      "Content-Type":"application/json",
      "role":"admin"
    },
    body: JSON.stringify({name})
  });

  alert("Position added");
  loadDropdowns();
}

// ===== ADD CANDIDATE =====
async function addCandidate(){
  const name = document.getElementById("candidateName").value.trim();
  const teamId = Number(document.getElementById("team").value);
  const positionId = Number(document.getElementById("position").value);

  if(!name || !teamId || !positionId){
    alert("Fill all fields");
    return;
  }

  const res = await fetch(API+"candidate",{
    method:"POST",
    headers:{
      "Content-Type":"application/json"
    },
    body: JSON.stringify({
      name,
      teamId,
      positionId
    })
  });

  const text = await res.text();
  console.log("ADD RESPONSE:", res.status, text);

  if(res.status !== 200){
    alert("Add failed: " + text);
    return;
  }

  alert("Candidate added");

  loadDropdowns();
  loadCharts();
}

// ===== LOAD RESULTS =====
async function loadResults(){
  try{
    const res = await fetch(API+"vote/results");
    const data = await res.json();

    const leaderBox = document.getElementById("leaderboard");
    const teamBox = document.getElementById("teamResults");

    // ===== LEADERBOARD (PER POSITION) =====
    let leaderHTML = "<h3>🏆 Leading per Position</h3>";

    data.forEach(p=>{
      let max = 0;
      p.candidates.forEach(c=>{
        if(c.votes > max) max = c.votes;
      });

      leaderHTML += `<div class="card">`;
      leaderHTML += `<h4>${p.position}</h4>`;

      p.candidates.forEach(c=>{
        const isLeader = c.votes === max;

        leaderHTML += `
          <p style="
            padding:5px;
            border-radius:5px;
            background:${isLeader ? "#22c55e" : "transparent"};
          ">
            ${c.name} - ${c.votes}
          </p>
        `;
      });

      leaderHTML += `</div>`;
    });

    leaderBox.innerHTML = leaderHTML;


    // ===== GROUP BY TEAM =====
    let teams = {};

    data.forEach(p=>{
      p.candidates.forEach(c=>{
        if(!teams[c.teamName]) teams[c.teamName] = [];
        teams[c.teamName].push({
          name:c.name,
          votes:c.votes,
          position:p.position
        });
      });
    });

    let teamHTML = "<h3>👥 Results by Team</h3>";

    Object.keys(teams).forEach(team=>{
      teamHTML += `<div class="card">`;
      teamHTML += `<h4>${team}</h4>`;

      teams[team].forEach(c=>{
        teamHTML += `
          <p>${c.position} - ${c.name}: ${c.votes}</p>
        `;
      });

      teamHTML += `</div>`;
    });

    teamBox.innerHTML = teamHTML;

  }catch(e){
    console.error("RESULT ERROR:", e);
  }
}

let charts = [];

async function loadCharts(){
  const res = await fetch(API+"vote/results?nocache=" + Date.now()); // no cache
  const data = await res.json();

  const box = document.getElementById("charts");

  // destroy old charts
  charts.forEach(c => c.destroy());
  charts = [];

  box.innerHTML = "";

  data.forEach(p => {
    // safe max even if all zeros
    const max = Math.max(0, ...p.candidates.map(c => c.votes || 0));

    const wrapper = document.createElement("div");
    wrapper.className = "chart-card";

    const canvas = document.createElement("canvas");
    wrapper.appendChild(canvas);
    box.appendChild(wrapper);

    const labels = p.candidates.map(c => c.name);
    const values = p.candidates.map(c => c.votes || 0);

    const colors = p.candidates.map(c =>
      (c.votes || 0) === max && max > 0 ? "#22c55e" : "#475569"
    );

    const chart = new Chart(canvas, {
      type: "bar",
      data: {
        labels,
        datasets: [{
          data: values,
          backgroundColor: colors,
          barThickness: 14
        }]
      },
      options: {
        responsive: true,
        maintainAspectRatio: false,
        plugins: {
          legend: { display: false },
          title: { display: true, text: p.position, color: "white" }
        },
        scales: {
          x: { ticks: { color: "white" } },
          y: { ticks: { color: "white" }, beginAtZero: true }
        }
      }
    });

    charts.push(chart);
  });
}

document.addEventListener("DOMContentLoaded", () => {

  const btnTeam = document.getElementById("btnTeam");
  if(btnTeam){
    btnTeam.addEventListener("click", addTeam);
  }

  const btnPosition = document.getElementById("btnPosition");
  if(btnPosition){
    btnPosition.addEventListener("click", addPosition);
  }

  const btnCandidate = document.getElementById("btnCandidate");
  if(btnCandidate){
    btnCandidate.addEventListener("click", addCandidate);
  }

});