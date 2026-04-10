using Econonet;
using Econonet.Behaviours;

var economy = Economy.Create()
    .AddDefaultInit(1000, 40_000)
    .Build();

for (int i = 0; i < 1000; i++)
    economy.Tick();