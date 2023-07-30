string permission="admin|manager";
int level;
Console.WriteLine("enter the level");
level=Convert.ToInt32(Console.ReadLine());
if (permission.Contains("admin"))
{
if (level>55)
{
    Console.WriteLine("welcome super admin");
}
   else
   {
    Console.WriteLine("welcome admin user");
   }
}
else if (permission.Contains("manager"))
{
    if (level>=20 && level<=54)
    {
        Console.WriteLine("contact the admin");
    }
    else{
        Console.WriteLine("you do not have sufficient privilages");
    }
    
}
else{
    Console.WriteLine("you do not have sufficient privalages");
}