namespace RobotoDalys
{
    internal interface IDalis
    {
            string Pavadinimas { get; set; }
            int Gyvybe { get; set; }
            int Kaina { get; set; }
            int Svoris { get; set; }

            void didejaGyvybe();

            void mazejaGyvybe();
        }
    
}