:root{
  --bg-1: #071025; --bg-2:#0a0f1a; --card:#0f1724; --accent1:#7c3aed; --accent2:#06b6d4; --glass: rgba(255,255,255,0.03);
  --muted:#9aa4b2; --radius:14px; --maxw:1100px; --glass-2: rgba(255,255,255,0.02);
  --glass-border: rgba(255,255,255,0.04);
}
*{box-sizing:border-box}
html,body{height:100%}
body{
  margin:0; font-family:Inter,system-ui,Arial; background:radial-gradient(1200px 600px at 10% 10%, rgba(124,58,237,0.12), transparent), radial-gradient(900px 400px at 90% 90%, rgba(6,182,212,0.08), transparent), linear-gradient(180deg,var(--bg-1),var(--bg-2)); color:#e6eef6; display:flex; align-items:center; justify-content:center; padding:28px;
}

.app{width:100%; max-width:var(--maxw); display:flex; gap:20px; align-items:flex-start}

/* Left column */
.panel{flex:1; background:linear-gradient(180deg, rgba(255,255,255,0.02), rgba(255,255,255,0.01)); border-radius:var(--radius); padding:20px; box-shadow:0 10px 40px rgba(2,6,23,0.6); border:1px solid var(--glass-border);}

header{display:flex; align-items:center; gap:16px; margin-bottom:12px}
.logo{width:64px; height:64px; border-radius:12px; background:linear-gradient(135deg,var(--accent1),var(--accent2)); display:flex; align-items:center; justify-content:center; font-weight:800; font-family:Poppins,Inter; font-size:20px; color:white; box-shadow:0 8px 30px rgba(11,22,40,0.6)}
h1{margin:0; font-size:20px}
p.lead{margin:0; color:var(--muted); font-size:13px}

form textarea{width:100%; min-height:140px; resize:vertical; background:linear-gradient(180deg, rgba(255,255,255,0.01), rgba(255,255,255,0.005)); border:1px solid var(--glass-border); color:inherit; padding:14px; border-radius:12px; font-size:14px; line-height:1.45}
.row{display:flex; gap:10px; margin-top:12px}
input[type=text]{flex:1; padding:10px 12px; border-radius:10px; border:1px solid var(--glass-border); background:transparent; color:inherit}

.btn{background:linear-gradient(90deg,var(--accent2),var(--accent1)); border:none; padding:10px 14px; border-radius:12px; cursor:pointer; color:white; font-weight:700; letter-spacing:0.2px; box-shadow:0 8px 30px rgba(12,18,30,0.5); transition:transform .12s ease, box-shadow .12s ease}
.btn:active{transform:translateY(1px)}

.muted{color:var(--muted); font-size:13px}
.small{font-size:12px}

.meta-row{display:flex; gap:8px; align-items:center; margin-top:14px}
.pill{padding:6px 10px; border-radius:999px; background:var(--glass-2); border:1px solid var(--glass-border); font-size:13px}

/* Right column */
.sidebar{width:380px}
.searchbar{display:flex; gap:8px; align-items:center}
.searchbar input{flex:1; padding:10px 12px; border-radius:10px; border:1px solid var(--glass-border); background:transparent}
select{padding:10px 12px; border-radius:10px; border:1px solid var(--glass-border); background:transparent}

.list{margin-top:12px; display:grid; gap:12px; max-height:62vh; overflow:auto; padding-right:6px}
.conf{padding:12px; border-radius:12px; background:linear-gradient(180deg, rgba(255,255,255,0.015), rgba(255,255,255,0.01)); border:1px solid rgba(255,255,255,0.02); display:flex; gap:10px; align-items:flex-start; transition:transform .12s ease, box-shadow .12s ease}
.conf:hover{transform:translateY(-6px); box-shadow:0 18px 40px rgba(2,6,23,0.5)}

.meta{display:flex; justify-content:space-between; gap:8px; font-size:12px; color:var(--muted)}
.actions{display:flex; gap:8px}
.icon-btn{background:transparent; border:1px solid var(--glass-border); padding:6px 8px; border-radius:10px; cursor:pointer}

.empty{color:var(--muted); text-align:center; padding:18px}

/* Modal */
.modal{position:fixed; inset:0; display:flex; align-items:center; justify-content:center; background:rgba(2,6,23,0.6); z-index:60}
.modal-card{width:min(720px,95%); background:linear-gradient(180deg,#071026,#081225); padding:20px; border-radius:16px; border:1px solid var(--glass-border)}
.close{margin-left:auto}

/* tiny toasts */
.toast{position:fixed; right:20px; bottom:20px; background:linear-gradient(90deg,var(--accent1),var(--accent2)); color:#021; padding:10px 14px; border-radius:10px; box-shadow:0 8px 30px rgba(12,18,30,0.6)}

@media (max-width:980px){ .app{flex-direction:column} .sidebar{width:100%} }
