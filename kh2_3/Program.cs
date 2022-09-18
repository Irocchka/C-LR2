using System;

class DocumentWorker
{
    public virtual void OpenDocument() 
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument() 
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }
    public virtual void SaveDocument() 
    {
        Console.WriteLine("Cохранение документо доступно в версии Pro ");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате,сохраненные в остальных форматах доступно в версии Expert");
    }
}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом форате");
    }
}
    class Program
    {
    static void Main(string[] args)
    {
        string pro_key = "mew";
        string exp_key = "mrr";
        Console.WriteLine("У вас есть ключ доступа pro или exp? " + " Если да,то введите 1 " + " Если нет,то 0");
        int frr = Convert.ToInt32(Console.ReadLine());
        if (frr == 1)
        {
            Console.WriteLine("Введите ключ достуа");
            string f = Convert.ToString(Console.ReadLine());
            if (f == pro_key)
            {
                ProDocumentWorker pro = new ProDocumentWorker();
                Console.WriteLine("Что выхотите сделать? 0-открыть;1-отредактировать;2-сохранить");
                int fr = Convert.ToInt32(Console.ReadLine());
                if (fr == 0)
                {
                    pro.OpenDocument();
                }
                else if (fr == 1)
                {
                    pro.EditDocument();
                }
                else if (fr == 2)
                {
                    pro.SaveDocument();
                }
            }
            else if (f == exp_key)
            {
                ExpertDocumentWorker exr = new ExpertDocumentWorker();
                Console.WriteLine("Что выхотите сделать? 0-открыть;1-отредактировать;2-сохранить");
                int few = Convert.ToInt32(Console.ReadLine());
                if (few == 0)
                {
                    exr.OpenDocument();
                }
                else if (few == 1)
                {
                    exr.EditDocument();
                }
                else if (few == 2)
                {
                    exr.SaveDocument();
                }
            }
        }
        else
        {
            DocumentWorker doc = new DocumentWorker();
            Console.WriteLine("Что выхотите сделать? 0-открыть;1-отредактировать;2-сохранить");
            int few = Convert.ToInt32(Console.ReadLine());
            if (few == 0)
            {
                doc.OpenDocument();
            }
            else if (few == 1)
            {
                doc.EditDocument();
            }
            else if (few == 2)
            {
                doc.SaveDocument();
            }
        }
      }
    }
