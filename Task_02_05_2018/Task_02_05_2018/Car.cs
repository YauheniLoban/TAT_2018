namespace Task_02_05_2018
{
    /// <summary>
    /// class containing information about the car
    /// </summary>
    class Car
    {
        string mark;       
        string model;

        public Car(string mark, string model)
        {
            this.mark = mark;
            this.model = model;
        }  

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
