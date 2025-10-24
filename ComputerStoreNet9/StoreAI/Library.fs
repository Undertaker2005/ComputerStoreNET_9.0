namespace StoreAI

open System.Collections.Generic 

// 🔸 Перелік категорій товарів — використовується для класифікації
type Category = 
    | CPU 
    | GPU 
    | RAM

// 🔸 Клас Product — описує один товар
[<AllowNullLiteral>] // 🔹 Дозволяє null-значення для CLR-сумісності (необхідно для C++/CLI і C#)
type Product(name: string, price: float, category: Category, isSelected: bool) =
    member val Name = name with get, set           // 🔹 Назва товару
    member val Price = price with get, set         // 🔹 Ціна товару
    member val Category = category with get, set   // 🔹 Категорія (CPU, GPU, RAM)
    member val IsSelected = isSelected with get, set // 🔹 Чи вибраний користувачем (для чекбоксу в UI)

module ProductModule =
    // 🔸 Метод, який повертає список попередньо визначених товарів
    let getProducts () : List<Product> =
        let items = [
            Product("Intel i7-11700", 320.0, CPU, false)
            Product("NVIDIA RTX 3070", 600.0, GPU, false)
            Product("16GB DDR4 RAM", 80.0, RAM, false)
            Product("Intel Ryzen 5 5735H", 790.0, CPU, false)
            Product("NVIDIA RTX 1060", 150.0, GPU, false)
            Product("8GB DDR3 RAM", 35.0, RAM, false)
        ]
        List<Product>(items) // 🔹 Повертаємо .NET-список для сумісності з C++/CLI та C#
