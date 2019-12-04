using System;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker doc = null;
          
            while (doc == null)
            {  
                Console.WriteLine("Enter the KEY!('pro'/'exp')");
                string line = Console.ReadLine();
                if (line == "pro")
                    doc = new ProDocumentWorker();
                else if (line == "exp")
                    doc = new ExpertDocumentWorker();
                else 
                    doc = new DocumentWorker();
            }
         
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
           
        }
    }
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");

        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
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
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
     }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
        
    }
}
