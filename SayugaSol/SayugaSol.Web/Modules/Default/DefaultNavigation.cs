using Serenity.Navigation;
using Def = SayugaSol.Default.Pages;

[assembly: NavigationMenu(1000, "General", icon: "icon-screen-desktop")]
[assembly: NavigationLink(int.MaxValue, "Default/Skill", typeof(Def.SkillController))]
[assembly: Serenity.Navigation.NavigationLink(int.MaxValue, "Default/Contacts", typeof(SayugaSol.Default.Pages.ContactsController))]
[assembly: Serenity.Navigation.NavigationLink(int.MaxValue, "Default/Certification", typeof(SayugaSol.Default.Pages.CertificationController))]
[assembly: Serenity.Navigation.NavigationLink(int.MaxValue, "Default/Employee", typeof(SayugaSol.Default.Pages.EmployeeController))]
