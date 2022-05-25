namespace Lab3_UniteTest_Moq_ParkCar.Models
{
    public class Pass
    {
        ParkingContext context;

        public int ID { get; set; }
        public string Purchaser { get; set; }
        public bool Premium { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public Pass(ParkingContext p)
        {
            context = p;
        }
        public Pass()
        {

        }


        public virtual void CreatePass(Pass pass)
        {
            if (pass.Purchaser.Length < 3 || pass.Purchaser.Length > 20)
            {
                throw new NullReferenceException("Purchaser should be between 3 to 20");
            }
            if (pass.Capacity < 1)
            {
                throw new NullReferenceException("Capacity should be greater than 0");
            }

           context.Add(pass);

        }
        public virtual void CreateParkingSpot(Pass pass)
        {
            if (pass.Purchaser.Length < 3 || pass.Purchaser.Length > 20)
            {
                throw new NullReferenceException("Purchaser should be between 3 to 20");
            }
            context.Add(pass);

        }
    }
}
