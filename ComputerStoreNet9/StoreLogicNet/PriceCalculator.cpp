#include "pch.h"
#include "PriceCalculator.h"

using namespace System;
using namespace System::Collections::Generic;
using namespace StoreAI;

namespace StoreLogicNet {

    // 🔸 Конструктор: ініціалізує порожній список товарів
    PriceCalculator::PriceCalculator()
    {
        cachedProducts = gcnew List<Product^>();
    }

    // 🔸 Метод для збереження списку товарів, переданого з C#
    void PriceCalculator::SetProducts(List<Product^>^ products)
    {
        cachedProducts = products;
    }

    // 🔸 Основний метод: обчислює загальну суму, знижку і повертає результат
    PriceResult^ PriceCalculator::CalculateTotal()
    {
        double sum = 0;

        // 🔹 Обчислення суми тільки для вибраних товарів (IsSelected == true)
        for each (Product ^ p in cachedProducts)
        {
            if (p->IsSelected)
                sum += p->Price;
        }

        // 🔹 Визначення знижки залежно від суми
        int discountPercent = 0;
        if (sum < 500)
            discountPercent = 10;
        else if (sum < 1000)
            discountPercent = 15;
        else
            discountPercent = 20;

        // 🔹 Обчислення суми зі знижкою
        double discounted = sum * (1.0 - (discountPercent / 100.0));

        // 🔹 Створення об'єкта результату і заповнення полів
        PriceResult^ result = gcnew PriceResult();
        result->OriginalPrice = sum;
        result->DiscountedPrice = discounted;
        result->DiscountPercent = discountPercent;

        return result;
    }
}
