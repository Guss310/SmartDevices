using AdapterExample;
using NUnit.Framework;

using NecessaryClass;


namespace Tests
{
    /// <summary>
    /// Clase de tests
    /// </summary>
    public class SmartDevicesTests
    {
        /// <summary>
        /// Se testea que un Plug es adaptado a ISmartDevice
        /// </summary>
        /// 
        [Test]
        public void AdapterTest()
        {
            Plug plug = new Plug("1");
            ISmartDevice SmartPlug = new driver(plug);
            SmartPlug.Off();
            SmartPlug.On();
            Assert.AreEqual(SmartPlug.GetStatus(), "on");
        }
    }
}
