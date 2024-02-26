string permission = "Admin|Manager";
int level = 55;
bool isAdmin = permission.Contains("Admin");
bool isManager = permission.Contains("Manager");

/*
 * This block evaluates the permission and level of the user
 * It displays a message following these rules :
 * Admin of level > 55      => Welcome, Super Admin user.
 * Admin of level <=55      => Welcome, Admin user.
 * Manager of level >= 20   => Contact an Admin for access.
 * Any other case           => You do not have sufficient privileges.
*/
if (isAdmin)
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (isManager && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}