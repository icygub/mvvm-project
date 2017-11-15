
namespace Project.Models {
    class CargoPlane : BaseObject {

        public CargoPlane(int planeNumber, string company, int mileagePerTank, int seatCapacity, int weightLbsCapacity) :
            base(planeNumber) {
            this.Company = company;
            this.MileagePerTank = mileagePerTank;
            this.SeatCapacity = seatCapacity;
            this.WeightLbsCapacity = weightLbsCapacity;
        }

        public string Company {
            get; set;
        }

        public int MileagePerTank {
            get; set;
        }

        public int SeatCapacity {
            get; set;
        }

        public int WeightLbsCapacity {
            get; set;
        }
    }
}
