using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RUMExample.Tests.Utils
{
    [TestClass]
    public class ViewHelpersTest
    {
        [TestMethod]
        public void validate_ShouldRenderRum_false_when_action_is_in_collection()
        {

            Assert.IsFalse(RUMExample.Utils.ViewHelpers.ShouldRenderRum("Home", "Index"));
        }

        [TestMethod]
        public void validate_ShouldRenderRum_true_when_action_is_in_collection()
        {
            Assert.IsTrue(RUMExample.Utils.ViewHelpers.ShouldRenderRum("Home", "Contact"));
        }

        [TestMethod]
        public void validate_ShouldRenderRum_true_when_action_is_emptystring()
        {
            Assert.IsTrue(RUMExample.Utils.ViewHelpers.ShouldRenderRum("Home", ""));
        }

        [TestMethod]
        public void validate_ShouldRenderRum_true_when_controller_is_emptystring()
        {
            Assert.IsTrue(RUMExample.Utils.ViewHelpers.ShouldRenderRum("", "Index"));
        }
    }
}
