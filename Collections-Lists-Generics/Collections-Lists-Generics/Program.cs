#region ExceptionTask
using Collections_Lists_Generics.Controllers;
using Collections_Lists_Generics.Helpers.Exceptions;

void Calculate()
{
    bool isCorrect = true;
    try
    {
        int a = 5;
        int b = 0;
        // var result = a / b;
        //Console.WriteLine(result);
        //if (b == 0)
        //{
        //    return;
        //}
        var result = a / b;
        Console.WriteLine(result);


        //int[] arr = { 1, 2, 3 };
        //arr[5] = 100;
    }
    //catch (DivideByZeroException ex)
    //{

    //       Console.WriteLine(ex.Message);
    //   }
    //   catch (IndexOutOfRangeException ex)
    //   {

    //       Console.WriteLine(ex.Message);
    //   }
    catch (Exception ex)
    {
        isCorrect = false;

    }
    finally
    {
        SendMessage(isCorrect);
    }
}
//Calculate(); 

void SendMessage(bool isCorrect)
{

    if (isCorrect)
    {
        Console.WriteLine("succesfully");
    }
    else
    {
        Console.WriteLine("failed");
    }
}


string GetById(int? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException("id");
            //throw new ArgumentNullException(nameof(id),"Salam ,menem exception");
            //ArgumentNullException.ThrowIfNull(id);
            throw new CustomArgumentNullException("Argument cAnnot be null");
        }
        return "Salam";
    }
    catch (Exception ex)
    {

        return ex.Message;
    }
}
var result = GetById(null);
//Console.WriteLine(result);
//////////////////////////////////////////
/////2. Ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin.


MathController mathController = new MathController();
//mathController.Factorial();



//3. Login ucun custom exception yazib isdifade etmek. Eger email ve yaxud password sehvdirse custom exception istifade edin. Models, Services, Controller folderleriniz olacaq. Service mentiqi ile yazirsiz. 

UserController userController = new UserController();
//userController.GetAll();
//userController.Login();
//userController.Login2
#endregion
#region CollectionsPractice
//Repository<string> data1=new Repository<string>();
//Repository<int> data2 = new Repository<int>();
//Repository<bool> data3 = new Repository<bool>();
//Repository<Book> data4 = new Repository<Book>();

//ArrayList list1= new ArrayList();
//list1.Add(100);
////list1.Remove(100);
//list1.Add("salam");
//list1.Add(true);
//foreach (var item in list1)
//{
//    Console.WriteLine(item);
//}

//Hashtable hashtable= new Hashtable();
//hashtable.Add("role","admin");
//hashtable.Add("name","Nesir");
//hashtable.Add(100, "Nesir");
//hashtable.Add(2100, 200);
////keyler eyni ola bilmez


//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key+"-"+item.Value);
//}

//SortedList sortedList = new SortedList();
//sortedList.Add(5,200);
//sortedList.Add(100, 200);
//sortedList.Add(55, 100);

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}
//SortedList<string,int>datas=new SortedList<string,int>();
//datas.Add("roleId", 100);
//datas.Add("age", 30);

//foreach (KeyValuePair<string,int> data in datas)
//{
//    Console.WriteLine(data.Key+"-"+data.Value);
//}
//Dictionary<string,string>datas = new Dictionary<string,string>();
//datas.Add("test1","salam1");
//datas.Add("test2", "salam2");
//datas.Add("test3", "salam3");

//foreach (KeyValuePair<string, string> data in datas)
//{
//    Console.WriteLine(data.Key + "-" + data.Value);
//}
//foreach (KeyValuePair<string, string> data in datas)
//{
//    if (data.Value == "salam3")
//    {
//        Console.WriteLine(data.Value);
//    }

//}
//Console.WriteLine(datas["test1"]);

//Stack<int> nums = new();
//nums.Push(1);
//nums.Push(100);
//nums.Push(18);
//foreach (int item in nums)
//{
//    Console.WriteLine(item);
//}


//Queue<int> nums = new Queue<int>();
//nums.Enqueue(1);
//nums.Enqueue(2);
//nums.Enqueue(3);
//foreach (int item in nums)
//{
//    Console.WriteLine(item);
//}


//List<int> numbers = new List<int>() { 1, 23, 4, 5 };

//List<int> numbers2 = new List<int>() { 1, 23, 4, 5 };



//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//Console.WriteLine(numbers[1]);

//Console.WriteLine(numbers.Count());

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//foreach (int item in numbers)
//{

//    Console.WriteLine(item);
//}


//numbers.Remove(23);
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}


//numbers.AddRange(numbers2);
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
#endregion

#region ListTask

//foreach (var item in AppDbContext.customer)
//{
//    Console.WriteLine(item.FullName);
//}

//AppDbContext.customer.Add(new Customer { FullName = "test" });
//foreach (var item in AppDbContext.customer)
//{
//    Console.WriteLine(item.FullName);
//}

CustomerController customerController = new CustomerController();
//customerController.GetAll();
//customerController.GetById();
//customerController.GetAllByAge();
//customerController.GetAllCountOfDatas();
//customerController.DescendingOrderByAge();
//customerController.AscendingOrderByAge();
#endregion


