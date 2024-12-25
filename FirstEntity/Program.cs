using FirstEntity;

using (FirstContext db=new FirstContext())
{
    //добавление
    //User tom = new User() { Id = 1, Name = "Tom", Age = 20 };
    //User jerry = new User() { Id = 2, Name = "Jerry", Age = 25 };
    //db.Users.Add(tom);
    //db.Users.Add(jerry);
    //db.SaveChanges();

    var users =db.Users.ToList();
    foreach (var u in users)
        Console.WriteLine(u.Name+" "+u.Age);

    //изменение
    //User? user=db.Users.FirstOrDefault(p=>p.Id==2);
    //if (user != null)
    //{
    //    user.Age= 30;
    //    db.Users.Update(user);
    //    db.SaveChanges();
    //}
    //foreach (var u in users)
    //    Console.WriteLine(u.Name + " " + u.Age);
    //удаление
    User? user = db.Users.FirstOrDefault(p => p.Id == 2);
    if (user != null)
    {
        db.Users.Remove(user);
        db.SaveChanges();
    }
    users = db.Users.ToList();
    foreach (var u in users)
        Console.WriteLine(u.Name + " " + u.Age);

}