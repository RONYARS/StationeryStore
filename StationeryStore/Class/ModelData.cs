using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStore.Class
{
    public class ModelData
    {
        static public Dictionary<string, string[]> Post = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"НаименованиеДолжности"} }, //без ключевого поля
            { "Header" , new string[] {"Номер должности","Наименование должности" } },
            { "FieldsCode", new string[] {"КодДолжности"} },
            { "TableName",new string[] {"Должность"} }
        };

        static public Dictionary<string, string[]> EmployeePersonalData = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"ФИО","Пол","Email-Сотрудника","ПаспортныеДанные","ТелефонСотрудника"} }, //без ключевого поля
            { "Header" , new string[] {"Номер сотрудника", "ФИО", "Пол", "Email", "Паспортные данные", "Телефон" } },
            { "FieldsCode", new string[] {"КодСотрудника"} },
            { "TableName",new string[] {"ЛичныеДанныеСотрудника"} }
        };

        static public Dictionary<string, string[]> EmployeeWorkData = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"ДолжностиКод","ГрафикРаботы","ЗаработнаяПлата","ДатаУвольнение","ДатаПриемаНаРаботу","МагазинаКод","КассыКод"} }, 
            { "Header" , new string[] {"Номер сотрудника", "Номер должности", "График работы", "Заработная плата", "Дата увольнение", "Дата приема на работу", "Номер магазина", "номер кассы" } },
            { "FieldsCode", new string[] {"КодСотрудника"} },
            { "TableName",new string[] {"РабочиеДанныеСотрудника"} }
        };

        static public Dictionary<string, string[]> CashRegister= new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"МагазинаКод"} }, //без ключевого поля
            { "Header" , new string[] {"Номер кассы", "Номер магазина" } },
            { "FieldsCode", new string[] {"КодКассы"} },
            { "TableName",new string[] {"Касса"} }
        };

        static public Dictionary<string, string[]> Shop = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"НаименованиеМагазина","АдресМагазина"} }, //без ключевого поля
            { "Header" , new string[] {"Номер магазина", "Наименование магазина","Адрес" } },
            { "FieldsCode", new string[] {"КодМагазина"} },
            { "TableName",new string[] {"Магазин"} }
        };

        static public Dictionary<string, string[]> Stock = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"АдресСклада","МагазинаКод","КоличествоТовараВналичии"} }, //без ключевого поля
            { "Header" , new string[] {"Номер склада", "Адрес", "Номер магазина", "Кол-во товара в наличии"} },
            { "FieldsCode", new string[] {"КодСклада"} },
            { "TableName",new string[] {"Склад"} }
        };

        static public Dictionary<string, string[]> Sale = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"НаименованиеТовара","ВремяПродажи","ДатаПродажи","КассыКод","СоставаПродажиКод"} }, //без ключевого поля
            { "Header" , new string[] {"Номер продажи", "Наименование товара", "Время продажи", "Дата продажи", "Номер кассы", "Номер состава продажи" } },
            { "FieldsCode", new string[] {"КодПродажи"} },
            { "TableName",new string[] {"Продажа"} }
        };

        static public Dictionary<string, string[]> CompositionSales = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"ТовараКод","КоличествоПродТовара","ЦенаПродажиЕдТовара"} }, //без ключевого поля
            { "Header" , new string[] {"Номер состава", "Номер товара", "Кол-во проданного товара", "Цена продажи за ед. товара"} },
            { "FieldsCode", new string[] {"КодСоставаПродажи"} },
            { "TableName",new string[] {"СоставПродажи"} }
        };

        static public Dictionary<string, string[]> Product = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"СкладаКод","ПоставщикаКод","НаименованиеТовара","Описание","ТипТовараКод","СрокГодности","СтранаПроизводителя","Производитель"} },
            { "Header" , new string[] {"Номер товара", "Номер склада", "Номер поставщика", "Наименование товара", "Описание", "Номер типа товара", "Срок годности", "Страна производителя", "Производитель" } },
            { "FieldsCode", new string[] {"КодТовара"} }, 
            { "TableName",new string[] {"Товар"} }
        };

        static public Dictionary<string, string[]> ProductType = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] { "НаименованиеТипаТовара" } }, //без ключевого поля
            { "Header" , new string[] {"Номер типа товара", "Тип товара" } },
            { "FieldsCode", new string[] {"КодТипаТовара"} },
            { "TableName",new string[] {"ТипТовара"} }
        };

        static public Dictionary<string, string[]> Provider = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"НаименованиеПоставщика","ТелефонПоставщика","Email-Поставщика"} }, //без ключевого поля
            { "Header" , new string[] { "Номер поставщика", "Наименование поставщика", "Телефон", "Email"} },
            { "FieldsCode", new string[] {"КодПоставщика"} },
            { "TableName",new string[] {"Поставщик"} }
        };

        static public Dictionary<string, string[]> Supply = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"ДатаПоставки","СоставаПоставкиКод"} }, //без ключевого поля
            { "Header" , new string[] {"Номер поставки", "Дата поставки", "Номер состава поставки" } },
            { "FieldsCode", new string[] {"КодПоставки"} },
            { "TableName",new string[] {"Поставка"} }
        };

        static public Dictionary<string, string[]> ScopeSupply = new Dictionary<string, string[]>()
        {
            { "Fields" , new string[] {"ТовараКод","КоличествоПостТовара","ЦенаПоставкиЕдТовара"} }, //без ключевого поля
            { "Header" , new string[] {"Номер состава", "Номер товара", "Кол-во поставляемого товара", "Цена поставки за ед. товара"} },
            { "FieldsCode", new string[] {"КодСоставаПоставки"} },
            { "TableName",new string[] {"СоставПоставки"} }
        };
       public Dictionary<string, Dictionary<string, string[]>> AllDictionary = new Dictionary<string, Dictionary<string, string[]>>()
        {
           {"Должность",Post },
           {"Товар",Product },
           {"ЛичныеДанныеСотрудника",EmployeePersonalData },
           {"РабочиеДанныеСотрудника",EmployeeWorkData },
           {"Касса",CashRegister },
           {"Магазин",Shop  },
           {"Продажа",Sale },
           {"СоставПродажи",CompositionSales },
           {"КодТипаТовара",ProductType },
           {"Поставщик",Provider },
           {"Поставка",Supply },
           {"СоставПоставки",ScopeSupply },
           {"Склад",Stock }
        };
    }
}
