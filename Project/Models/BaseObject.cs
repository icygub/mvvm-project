namespace Project.Models {
    public abstract class BaseObject {
        public BaseObject(int primaryKey) {
            PrimaryKey = primaryKey;
        }

        public int PrimaryKey {
            get; set;
        }
    }
}
