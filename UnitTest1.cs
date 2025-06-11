using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

using zd3_Rydnyh;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        // ������������ �������� ������ Food

        // ���������, ��� ������ Food ��������� ��������� ���������� ��������
        [TestMethod]
        public void Food_ShouldInitializePropertiesCorrectly()
        {
            var food = new Food("������", 0.5, 10);

            Assert.AreEqual("������", food.Name);
            Assert.AreEqual(0.5, food.Protein);
            Assert.AreEqual(10, food.Carbs);
        }

        // ��������� ������ �������� ��� �������� �������� �� �������: Carbs * 4 + Protein * 4
        [TestMethod]
        public void Food_CalculateQuality_ReturnsCorrectValue()
        {
            var food = new Food("�����", 1.2, 22);

            double expected = 22 * 4 + 1.2 * 4; // (22 * 4) + (1.2 * 4) = 88 + 4.8 = 92.8
            double actual = food.CalculateQuality();

            Assert.AreEqual(expected, actual);
        }

        // ���������, ��� ������ KallorFood ��������� ���������������� � ������ �������
        [TestMethod]
        public void KallorFood_ShouldInitializePropertiesCorrectly()
        {
            var kallorFood = new KallorFood("�������", 3, 50, 500);

            Assert.AreEqual("�������", kallorFood.Name);
            Assert.AreEqual(3, kallorFood.Protein);
            Assert.AreEqual(50, kallorFood.Carbs);
            Assert.AreEqual(500, kallorFood.Calories);
        }

        // ��������� ��������������� ����� CalculateQuality � KallorFood
        [TestMethod]
        public void KallorFood_CalculateQuality_ReturnsCorrectValue()
        {
            var kallorFood = new KallorFood("�������", 3, 50, 500);

            // ������� ��������: (50 * 4) + (3 * 4) = 200 + 12 = 212
            // ����� ��������: 212 * 1.2 + 500 * 7 = 254.4 + 3500 = 3754.4
            double expected = 212 * 1.2 + 500 * 7;
            double actual = kallorFood.CalculateQuality();

            Assert.AreEqual(expected, actual);
        }

        // ���������, ��� �������� ������ ��������� �����
        [TestMethod]
        public void FoodManager_InitialData_ShouldHaveTwoItems()
        {
            var manager = new FoodManager(); // ��������������, ��� ����������� ��������� �������� ������

            Assert.AreEqual(2, manager.FoodList.Count);

            Assert.AreEqual("������", manager.FoodList[0].Name);
            Assert.IsInstanceOfType(manager.FoodList[0], typeof(Food));

            Assert.AreEqual("�������", manager.FoodList[1].Name);
            Assert.IsInstanceOfType(manager.FoodList[1], typeof(KallorFood));
        }

        // ���������, ��� ��� ���������� �������� �������� ������ ������������� �� ���� �������
        [TestMethod]
        public void AddFood_ShouldIncreaseListCount_ByOne()
        {
            var manager = new FoodManager();
            int initialCount = manager.FoodList.Count;

            manager.AddFood("�����", 0.4, 15);

            Assert.AreEqual(initialCount + 1, manager.FoodList.Count);
            Assert.AreEqual("�����", manager.FoodList.Last().Name);
        }

        // ���������, ��� ��� ���������� ����������� �������� ������ ������������� �� ���� �������
        [TestMethod]
        public void AddKallorFood_ShouldIncreaseListCount_ByOne()
        {
            var manager = new FoodManager();
            int initialCount = manager.FoodList.Count;

            manager.AddKallorFood("���������", 2.0, 20, 250);

            Assert.AreEqual(initialCount + 1, manager.FoodList.Count);
            var newItem = manager.FoodList.Last();
            Assert.AreEqual("���������", newItem.Name);
            Assert.IsInstanceOfType(newItem, typeof(KallorFood));
        }

        // ��������� �������� �������� �� �������
        [TestMethod]
        public void RemoveFood_ByIndex_RemovesCorrectItem()
        {
            var manager = new FoodManager();
            int initialCount = manager.FoodList.Count;

            manager.RemoveFood(0); // ������� ������ �������

            Assert.AreEqual(initialCount - 1, manager.FoodList.Count);
            Assert.AreNotEqual("������", manager.FoodList[0].Name);
        }

        // ��������� �������� �������� �� ������
        [TestMethod]
        public void RemoveFood_ByObject_RemovesCorrectItem()
        {
            var manager = new FoodManager();
            var itemToRemove = manager.FoodList.FirstOrDefault(f => f.Name == "������");
            Assert.IsNotNull(itemToRemove);

            int initialCount = manager.FoodList.Count;

            manager.RemoveFood(itemToRemove);

            Assert.AreEqual(initialCount - 1, manager.FoodList.Count);
            Assert.IsFalse(manager.FoodList.Any(f => f.Name == "������"));
        }

        // ��������� ���������� ��������� �� ��������
        [TestMethod]
        public void FilterByQuality_ReturnsOnlyItemsWithHigherQuality()
        {
            var manager = new FoodManager();
            double q = 1000;
            var result = manager.FilterByQuality(q);

            Assert.IsTrue(result.Count > 0);
            foreach (var food in result)
            {
                Assert.IsTrue(food.CalculateQuality() > q);
            }
        }

        // ���������, ��� GetFullList ���������� ��� �������� ��������
        [TestMethod]
        public void GetFullList_ReturnsAllOriginalItems()
        {
            var manager = new FoodManager();
            var filtered = manager.FilterByQuality(1000);
            var fullList = manager.GetFullList();

            Assert.AreNotEqual(filtered.Count, fullList.Count);
            Assert.AreEqual(manager.FoodList.Count, fullList.Count);
        }
    }
}