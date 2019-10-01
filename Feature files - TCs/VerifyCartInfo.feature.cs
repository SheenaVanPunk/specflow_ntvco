// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace VSC.FeatureFiles_TCs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("User can see Promotion details in cart.")]
    public partial class UserCanSeePromotionDetailsInCart_Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VerifyCartInfo.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "User can see Promotion details in cart.", "    In order to be informed what I am shopping for\r\n    As a new user\r\n    I want" +
                    " to see relevant Promotion details in Cart depending on my selection.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX za 1 EUR - No Subscription")]
        public virtual void BOXZa1EUR_NoSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX za 1 EUR - No Subscription", null, ((string[])(null)));
#line 7
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
  testRunner.Given("that I select Box option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
        testRunner.When("I select \"BOX za 1 EUR\" Promotion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table1.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "BOX za 1 EUR"});
            table1.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
#line 11
        testRunner.Then("I see the following cart items", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX za 1 EUR - Subscription 3 months")]
        public virtual void BOXZa1EUR_Subscription3Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX za 1 EUR - Subscription 3 months", null, ((string[])(null)));
#line 17
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
  testRunner.Given("that I select Box option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
        testRunner.When("I select Promotion \"BOX za 1 EUR\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
        testRunner.And("I select Subscription \"3 meseca\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table2.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "BOX za 1 EUR"});
            table2.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table2.AddRow(new string[] {
                        "SubscriptionLenght",
                        "3 meseca"});
            table2.AddRow(new string[] {
                        "SubscriptionAmount",
                        "47.7 EUR"});
            table2.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table2.AddRow(new string[] {
                        "NewBoxPrice",
                        "1 EUR"});
            table2.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table2.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table2.AddRow(new string[] {
                        "Total",
                        "98.7 EUR"});
            table2.AddRow(new string[] {
                        "Savings",
                        "119 EUR"});
#line 21
        testRunner.Then("I see the following cart items", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX za 1 EUR - Subscription 6 months")]
        public virtual void BOXZa1EUR_Subscription6Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX za 1 EUR - Subscription 6 months", null, ((string[])(null)));
#line 35
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
        testRunner.When("I select Promotion \"BOX za 1 EUR\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
        testRunner.And("I select Subscription \"6 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table3.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "BOX za 1 EUR"});
            table3.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table3.AddRow(new string[] {
                        "SubscriptionLenght",
                        "6 meseci"});
            table3.AddRow(new string[] {
                        "SubscriptionAmount",
                        "95.4 EUR"});
            table3.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table3.AddRow(new string[] {
                        "NewBoxPrice",
                        "1 EUR"});
            table3.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table3.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table3.AddRow(new string[] {
                        "Total",
                        "146.4 EUR"});
            table3.AddRow(new string[] {
                        "Savings",
                        "119 EUR"});
#line 38
        testRunner.Then("I see the following cart items", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX za 1 EUR - Subscription 12 months")]
        public virtual void BOXZa1EUR_Subscription12Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX za 1 EUR - Subscription 12 months", null, ((string[])(null)));
#line 51
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 52
        testRunner.When("I select Promotion \"BOX za 1 EUR\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
        testRunner.And("I select Subscription \"12 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table4.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "BOX za 1 EUR"});
            table4.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table4.AddRow(new string[] {
                        "SubscriptionLenght",
                        "12 meseci"});
            table4.AddRow(new string[] {
                        "SubscriptionAmount",
                        "190.6 EUR"});
            table4.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table4.AddRow(new string[] {
                        "NewBoxPrice",
                        "1 EUR"});
            table4.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table4.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table4.AddRow(new string[] {
                        "Total",
                        "241.6 EUR"});
            table4.AddRow(new string[] {
                        "Savings",
                        "119 EUR"});
#line 54
        testRunner.Then("I see the following cart items", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("50% popusta na box - Predefined Subscription")]
        public virtual void _50PopustaNaBox_PredefinedSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("50% popusta na box - Predefined Subscription", null, ((string[])(null)));
#line 68
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 69
        testRunner.When("I select Promotion \"50% popusta na box\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table5.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "50% popusta na box"});
            table5.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table5.AddRow(new string[] {
                        "SubscriptionLenght",
                        "12 meseci"});
            table5.AddRow(new string[] {
                        "SubscriptionAmount",
                        "190.8 EUR"});
            table5.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table5.AddRow(new string[] {
                        "NewBoxPrice",
                        "60 EUR"});
            table5.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table5.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table5.AddRow(new string[] {
                        "Total",
                        "300.8 EUR"});
            table5.AddRow(new string[] {
                        "Savings",
                        "60 EUR"});
#line 70
        testRunner.Then("I see the following cart items", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX bez akcijske cene - No Subscription")]
        public virtual void BOXBezAkcijskeCene_NoSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX bez akcijske cene - No Subscription", null, ((string[])(null)));
#line 83
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 84
        testRunner.When("I select Promotion \"BOX bez akcijske cene\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table6.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table6.AddRow(new string[] {
                        "SubscriptionLenght",
                        "1 mesec"});
            table6.AddRow(new string[] {
                        "SubscriptionAmount",
                        "15.9 EUR"});
            table6.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table6.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table6.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table6.AddRow(new string[] {
                        "Total",
                        "185.9 EUR"});
#line 85
        testRunner.Then("I see the following cart items", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX bez akcijske cene - Subscription 3 months")]
        public virtual void BOXBezAkcijskeCene_Subscription3Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX bez akcijske cene - Subscription 3 months", null, ((string[])(null)));
#line 95
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 96
        testRunner.When("I select Promotion \"BOX bez akcijske cene\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
        testRunner.And("I select Subscription \"3 meseca\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table7.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table7.AddRow(new string[] {
                        "SubscriptionLenght",
                        "3 meseca"});
            table7.AddRow(new string[] {
                        "SubscriptionAmount",
                        "47.7 EUR"});
            table7.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table7.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table7.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table7.AddRow(new string[] {
                        "Total",
                        "217.7 EUR"});
#line 98
        testRunner.Then("I see the following cart items", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX bez akcijske cene - Subscription 6 months")]
        public virtual void BOXBezAkcijskeCene_Subscription6Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX bez akcijske cene - Subscription 6 months", null, ((string[])(null)));
#line 108
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 109
        testRunner.When("I select Promotion \"BOX bez akcijske cene\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
        testRunner.And("I select Subscription \"6 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table8.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table8.AddRow(new string[] {
                        "SubscriptionLenght",
                        "6 meseci"});
            table8.AddRow(new string[] {
                        "SubscriptionAmount",
                        "95.4 EUR"});
            table8.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table8.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table8.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table8.AddRow(new string[] {
                        "Total",
                        "265.4 EUR"});
#line 111
        testRunner.Then("I see the following cart items", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BOX bez akcijske cene - Subscription 12 months")]
        public virtual void BOXBezAkcijskeCene_Subscription12Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BOX bez akcijske cene - Subscription 12 months", null, ((string[])(null)));
#line 121
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 122
        testRunner.When("I select Promotion \"BOX bez akcijske cene\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
        testRunner.And("I select Subscription \"12 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table9.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table9.AddRow(new string[] {
                        "SubscriptionLenght",
                        "12 meseci"});
            table9.AddRow(new string[] {
                        "SubscriptionAmount",
                        "190.8 EUR"});
            table9.AddRow(new string[] {
                        "OriginalBoxPrice",
                        "120 EUR"});
            table9.AddRow(new string[] {
                        "ActivationFee",
                        "40 EUR"});
            table9.AddRow(new string[] {
                        "TransportationFee",
                        "10 EUR"});
            table9.AddRow(new string[] {
                        "Total",
                        "360.8 EUR"});
#line 124
        testRunner.Then("I see the following cart items", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 meseca gratis - No Subscription")]
        public virtual void _3MesecaGratis_NoSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 meseca gratis - No Subscription", null, ((string[])(null)));
#line 135
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 136
        testRunner.When("I select \"3 meseca gratis\" Promotion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table10.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "3 meseca gratis"});
            table10.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
#line 137
        testRunner.Then("I see the following cart items", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 meseca gratis - Subscription 3 months")]
        public virtual void _3MesecaGratis_Subscription3Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 meseca gratis - Subscription 3 months", null, ((string[])(null)));
#line 143
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 144
  testRunner.Given("that I select No Box option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 145
        testRunner.When("I select Promotion \"3 meseca gratis\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 146
        testRunner.And("I select Subscription \"3 meseca\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table11.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "3 meseca gratis"});
            table11.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table11.AddRow(new string[] {
                        "SubscriptionLenght",
                        "3 meseca"});
            table11.AddRow(new string[] {
                        "SubscriptionAmount",
                        "47.7 EUR"});
            table11.AddRow(new string[] {
                        "Total",
                        "47.7 EUR"});
#line 147
        testRunner.Then("I see the following cart items", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 meseca gratis - Subscription 6 months")]
        public virtual void _3MesecaGratis_Subscription6Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 meseca gratis - Subscription 6 months", null, ((string[])(null)));
#line 156
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 157
        testRunner.When("I select Promotion \"3 meseca gratis\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 158
        testRunner.And("I select Subscription \"6 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table12.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "3 meseca gratis"});
            table12.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table12.AddRow(new string[] {
                        "SubscriptionLenght",
                        "6 meseca"});
            table12.AddRow(new string[] {
                        "SubscriptionAmount",
                        "95.4 EUR"});
            table12.AddRow(new string[] {
                        "Total",
                        "95.4 EUR"});
#line 159
        testRunner.Then("I see the following cart items", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 meseca gratis - Subscription 12 months")]
        public virtual void _3MesecaGratis_Subscription12Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 meseca gratis - Subscription 12 months", null, ((string[])(null)));
#line 167
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 168
        testRunner.When("I select Promotion \"3 meseca gratis\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 169
        testRunner.And("I select Subscription \"12 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table13.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "3 meseca gratis"});
            table13.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table13.AddRow(new string[] {
                        "SubscriptionLenght",
                        "12 meseci"});
            table13.AddRow(new string[] {
                        "SubscriptionAmount",
                        "190.8 EUR"});
            table13.AddRow(new string[] {
                        "Total",
                        "190.8 EUR"});
#line 170
        testRunner.Then("I see the following cart items", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Plati 10 gledaj 12 meseci - Predefined Subscription")]
        public virtual void Plati10Gledaj12Meseci_PredefinedSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Plati 10 gledaj 12 meseci - Predefined Subscription", null, ((string[])(null)));
#line 179
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 180
        testRunner.When("I select Promotion \"Plati 10 gledaj 12 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table14.AddRow(new string[] {
                        "YellowRibbonPromoText",
                        "Plati 10 gledaj 12 meseci"});
            table14.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table14.AddRow(new string[] {
                        "SubscriptionLenght",
                        "12 meseci"});
            table14.AddRow(new string[] {
                        "SubscriptionAmount",
                        "190.8 EUR"});
            table14.AddRow(new string[] {
                        "Total",
                        "190.8 EUR"});
#line 181
        testRunner.Then("I see the following cart items", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Izaberi period trajanja pretplate - No Subscription")]
        public virtual void IzaberiPeriodTrajanjaPretplate_NoSubscription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Izaberi period trajanja pretplate - No Subscription", null, ((string[])(null)));
#line 189
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 190
        testRunner.When("I select Promotion \"Izaberi period trajanja pretplate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table15.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table15.AddRow(new string[] {
                        "SubscriptionLenght",
                        "1 mesec"});
            table15.AddRow(new string[] {
                        "SubscriptionAmount",
                        "15.9 EUR"});
            table15.AddRow(new string[] {
                        "Total",
                        "15.9 EUR"});
#line 191
        testRunner.Then("I see the following cart items", ((string)(null)), table15, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Izaberi period trajanja pretplate - Subscription 3 months")]
        public virtual void IzaberiPeriodTrajanjaPretplate_Subscription3Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Izaberi period trajanja pretplate - Subscription 3 months", null, ((string[])(null)));
#line 199
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 200
        testRunner.When("I select Promotion \"Izaberi period trajanja pretplate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
        testRunner.And("I select Subscription \"3 meseca\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table16.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table16.AddRow(new string[] {
                        "SubscriptionLenght",
                        "3 meseca"});
            table16.AddRow(new string[] {
                        "SubscriptionAmount",
                        "47.7 EUR"});
            table16.AddRow(new string[] {
                        "Total",
                        "47.7 EUR"});
#line 202
        testRunner.Then("I see the following cart items", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Izaberi period trajanja pretplate - Subscription 6 months")]
        public virtual void IzaberiPeriodTrajanjaPretplate_Subscription6Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Izaberi period trajanja pretplate - Subscription 6 months", null, ((string[])(null)));
#line 210
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 211
        testRunner.When("I select Promotion \"Izaberi period trajanja pretplate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 212
        testRunner.And("I select Subscription \"6 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table17.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table17.AddRow(new string[] {
                        "SubscriptionLenght",
                        "6 meseci"});
            table17.AddRow(new string[] {
                        "SubscriptionAmount",
                        "95.4 EUR"});
            table17.AddRow(new string[] {
                        "Total",
                        "95.4 EUR"});
#line 213
        testRunner.Then("I see the following cart items", ((string)(null)), table17, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Izaberi period trajanja pretplate - Subscription 12 months")]
        public virtual void IzaberiPeriodTrajanjaPretplate_Subscription12Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Izaberi period trajanja pretplate - Subscription 12 months", null, ((string[])(null)));
#line 220
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 221
        testRunner.When("I select Promotion \"Izaberi period trajanja pretplate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 222
        testRunner.And("I select Subscription \"12 meseci\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "value"});
            table18.AddRow(new string[] {
                        "ContractLength",
                        "24 meseca"});
            table18.AddRow(new string[] {
                        "SubscriptionLenght",
                        "12 meseci"});
            table18.AddRow(new string[] {
                        "SubscriptionAmount",
                        "190.8 EUR"});
            table18.AddRow(new string[] {
                        "Total",
                        "190.8 EUR"});
#line 223
        testRunner.Then("I see the following cart items", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
