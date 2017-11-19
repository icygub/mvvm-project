using System.ComponentModel;

namespace Project.Models {
    public abstract class BaseObject {
        private readonly int _primaryKey;

        public BaseObject(int primaryKey) {
            PrimaryKey = primaryKey;
        }

        public int PrimaryKey {
            get; set;
        }
    }
}
