using System;
using System.Collections.Generic;
class Работник
{
    protected int Id;
    protected string FIO;
    protected decimal Salary;
    protected decimal HoursPerWeek;
    protected decimal HoursPerMounth;
    protected decimal salaryPerHour;
    public Работник(int ID, string fio, decimal zp, decimal hoursperweek)
    {   Id = ID;
        FIO = fio;
        Salary = zp;
        HoursPerWeek = hoursperweek;
        HoursPerMounth = hoursperweek * 4;
    }


    public decimal SalaryPerHour()
    {
        salaryPerHour = Salary / HoursPerMounth;
            return (salaryPerHour);
    }
    public void output()
    {
        Console.WriteLine($"Id = {Id},ФИО: {FIO}, ЗП = {Salary}, Часы в неделю: {HoursPerWeek}, Ставка в час = {salaryPerHour }");
    }


}






namespace Lr2_Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Работник> работники = new List<Работник>();
            работники.Add(new Работник(1, "Комаров Роман Викторович", 30000, 20));
            работники.Add(new Работник(2, "Александров Михаил Юрьевич", 15000, 10));
            работники.Add(new Работник(3, "Кабарухин Дмитрий Олегович", 28000, 30));
            работники.Add(new Работник(4, "Антонов Дмитрий Васильевич", 70000, 50));
            работники.Add(new Работник(5, "Чернышов Александр Олегович", 30000, 20));
            decimal mediumSalaryPerHour = 0;
            int quantity = 0;
            foreach (var worker in работники)
            {
                mediumSalaryPerHour += worker.SalaryPerHour();
                ++quantity;
            }
            mediumSalaryPerHour = mediumSalaryPerHour / quantity;

            foreach (var worker in работники)
                worker.output();

            Console.WriteLine($"Средняя = {mediumSalaryPerHour}");
        }
    }
}
