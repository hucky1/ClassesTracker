using System.Collections.Generic;

namespace TrackerModel
{
    public static class TheoryModel
    {
        public static Dictionary<string, string> TheoryFiles { get; } = new()
        {
            { "Стартовая", "started.rtf" },
            { "ООП. Основные свойства ООП.", "oop.rtf" },

            { "Классы", "classes.rtf" },
            { "Спецификаторы", "specificators.rtf" },
            { "Виды элементов класса", "classElementKindsNode.rtf" },

            { "Поля и константы", "fieldsAndConstants.rtf" },

            { "Методы. Разница между простыми и статическими?", "staticMethods.rtf" },
            { "Разница между витруальными и аббстрактными методами?", "virtualAbstractMethods.rtf" },
            { "Объявление методов", "methodDeclaration.rtf" },
            { "Использование параметров", "paramsUsing.rtf" },

            { "Конструкторы", "constructors.rtf" },
            { "Ключевое слово this", "thisKeyword.rtf" },

            { "Сборка мусора и деструкторы", "garbageCollection.rtf" },

            { "Доступ к членам класса", "classMembersAccess.rtf" },
            { "Модификаторы доступа", "accessModifiers.rtf" },

            { "Модификаторы параметров", "paramsModifiers.rtf" },
            { "Модификатор REF", "refModifier.rtf" },
            { "Модификатор OUT", "outModifier.rtf" },
            { "Модификатор PARAMS", "paramsModifier.rtf" },

            { "Рекурсия", "recursion.rtf" },

            { "Ключевое слово STATIC", "staticKeyword.rtf" },
            { "Статические конструкторы", "staticConstructors.rtf" },
            { "Статические классы", "staticClasses.rtf" },

            { "Понятие индексатора", "indexerNotion.rtf" },
            { "Одномерные индексаторы", "oneDimIndexers.rtf" },
            { "Многомерные индексаторы", "multiDimIndexers.rtf" },

            { "Свойства. Аксессоры get и set", "propGetSet.rtf" },
            { "Автоматически генерируемые свойства", "automaticProp.rtf" },

            { "Понятие наследования", "inheritanceNotion.rtf" },
            { "Ключевое слово BASE", "baseKeyword.rtf" },
            { "Ключевое слово THIS", "thisKeywordInherit.rtf" },
            { "Ключевое слово SEALED", "sealedKeyword.rtf" },
        };
    }
}
