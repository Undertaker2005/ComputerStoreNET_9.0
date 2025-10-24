#pragma once

using namespace System;
using namespace System::Collections::Generic;
using namespace StoreAI;

namespace StoreLogicNet {

    // 🔸 Клас-результат, який містить повну інформацію про підсумок розрахунку
    public ref class PriceResult
    {
    public:
        double OriginalPrice;     // 🔹 Сума без знижки
        double DiscountedPrice;   // 🔹 Сума після застосування знижки
        int DiscountPercent;      // 🔹 Відсоток знижки (10, 15, 20)
    };

    // 🔸 Основний клас для обчислення ціни
    public ref class PriceCalculator
    {
    private:
        List<Product^>^ cachedProducts; // 🔹 Збережений список товарів, отриманий з F# і переданий з C#

    public:
        PriceCalculator();

        // 🔹 Метод для збереження списку товарів (викликається з C# після отримання з F#)
        void SetProducts(List<Product^>^ products);

        // 🔹 Основний метод: обчислює суму, знижку і повертає результат у вигляді об'єкта PriceResult
        PriceResult^ CalculateTotal();
    };
}
