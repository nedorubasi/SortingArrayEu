using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Sorting_Array
{
    /// <summary>
    /// Сводное описание для UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: добавьте логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestSortingArray()
        {
           
            ArrayList arrl_s = SortingArray.frmSortingArray.Arr_new();
            int _i_s = arrl_s.Count;
            ArrayList rez_s = SortingArray.frmSortingArray.SortArrL(arrl_s, false);
            int _i_r = rez_s.Count;
            // Результат ожидаем в той же размерности, как и входящий массив
            // Если для пункта отправления не будет найден пункт прибытия - возвращаемый массив будет другой размерности
            Assert.AreEqual(_i_s, _i_r, 
                            string.Format(
                                "При обработке карточек произошла ошибка.{0}Необходимо пересмотреть маршрут путешествия.",
                                Environment.NewLine));
        }
        [TestMethod]
        public void TestSortingArrayBad() // Моделируем ошибку в карточках 
        {
            ArrayList arrl_s = SortingArray.frmSortingArray.Arr_new_bad();
            int _i_s = arrl_s.Count;
            ArrayList rez_s = SortingArray.frmSortingArray.SortArrL(arrl_s, false);
            int _i_r = rez_s.Count;
            Assert.AreEqual(_i_s, _i_r, 
                           string.Format(
                               "При обработке карточек произошла ошибка.{0}Необходимо пересмотреть маршрут путешествия.",
                               Environment.NewLine));
        }
    }
}
