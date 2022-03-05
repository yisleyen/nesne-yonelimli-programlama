using NYP.Lib;

#region human & footballer
/*
OffensiveFootballer offensiveFootballer = new OffensiveFootballer();

offensiveFootballer.Name = "Sergen";
offensiveFootballer.Surname = "Yalçın";
offensiveFootballer.BirthDate = Convert.ToDateTime("1972-11-05");

List<string> offensiveTeamsPlayed = new List<string>();
offensiveTeamsPlayed.Add("Beşiktaş");
offensiveTeamsPlayed.Add("İstanbulspor");
offensiveTeamsPlayed.Add("Galatasaray");
offensiveTeamsPlayed.Add("Fenerbahçe");
offensiveTeamsPlayed.Add("Etimesgut Şekerspor");
offensiveTeamsPlayed.Add("Trabzonspor");
offensiveTeamsPlayed.Add("Eskişehirspor");
offensiveFootballer.TeamsPlayed = offensiveTeamsPlayed;

Console.WriteLine(offensiveFootballer.Breathe());
Console.WriteLine(offensiveFootballer.Shoot());

DefensiveFootballer defensiveFootballer = new DefensiveFootballer();

defensiveFootballer.Name = "Necip";
defensiveFootballer.Surname = "Uysal";
defensiveFootballer.BirthDate = Convert.ToDateTime("1991-01-24");

List<string> defensiveTeamsPlayed = new List<string>();
defensiveTeamsPlayed.Add("Beşiktaş");
defensiveFootballer.TeamsPlayed = defensiveTeamsPlayed;

Console.WriteLine(defensiveFootballer.Breathe());
Console.WriteLine(defensiveFootballer.Shoot());
*/
#endregion

#region employee

Boss boss = new Boss();
Manager manager = new Manager("Murat Özkan", 15, null);

Developer developer = new Developer("Kenan Demir", 9, manager);
Analyst analyst = new Analyst("Ayşe Demir", 6, manager);

manager.employees.AddRange(new List<Employee>() { developer, analyst });
boss.ManagerList.Add(manager);

boss.TotalSalaryFind();
boss.DistributeSalaries();
manager.DistributeSalaries();

#endregion