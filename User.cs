public class User{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname(){
        return $"{Name} {Surname}";
    }
}
public class Yo{
    public string Pais { get; set; }
    public string Ciudad { get; set; }
    public string DondeVive(){
        return $"{Pais} {Ciudad}";

    }
}
