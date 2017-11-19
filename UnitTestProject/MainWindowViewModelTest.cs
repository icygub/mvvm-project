using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.ViewModels;

namespace UnitTestProject {
    [TestClass]
    public class MainWindowViewModelTest {
        
        [TestClass]
        public class _CustomerBase_Should {
            [TestMethod]
            public void HaveSizeOf1_WhenOneCustomerIsAdded() {
                MainWindowViewModel model = new MainWindowViewModel();
                model.AddCustomer("john", 123, "adf", "fdsa", "asdf", 321, "asdf");
                Assert.IsTrue(model.CustomerBase.getListSize() == 1);
            }
        }
    }
}
