using KodlamaioDemo.DataAcces.Abstracts;
using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAcces.Concrets
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;   
        public InstructorDal()
        { 
            instructors = new List<Instructor>();

            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin ";
            instructor1.LastName = "Demiroğ";
            instructor1.Background = "Yazılım geliştirmeye lisede \"yazılım\" bölümünde okurken başladım.Üniversite hayatıma ÖSS 2003 Türkiye derecesiyle başladım. Sırasıyla Başkent ve ODTÜ'de Yönetim Bilişim Sistemleri (Lisans-Burslu) ve Tıp Bilişimi(Yüksek Lisans) okudum. Profesyonel iş hayatıma ise henüz üniversite birinci sınıftayken başladım.Ağırlıklı olarak Savunma Sanayisi, Bankacılık sektörlerine kurumsal yazılım geliştirme süreçleri konusunda danışmanlık veriyorum.Microsoft Certified Trainer (MCT) ,PMP ve ITIL sertifikalarına sahibim.\"Engin Demiroğ\" YouTube kanalımda ücretsiz eğitim videoları ve içerikleri paylaşmaktayım.Danışmanlık yaptığım kurumların bazıları : Merkez Bankası,TAI, Birleşmiş Milletler,NATO,İş Bankası, Akbank, Halkbank, Vakıfbank, Yapı Kredi Bankası, Ziraat Bankası, Emniyet, Başbakanlık, Cumhurbaşkanlığı, Hazine Müsteşarlığı, Maliye Bakanlığı, Tarım Bakanlığı, Tübitak.Danışmanlık veya eğitim verdiğim kurum sayısı son 10 yılda 300'ü geçmiştir.DevFramework ismiyle geliştirdiğim altyapı projem birçok kurum ve firmada yazılım geliştirme altyapısı olarak kullanılmaktadır.";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";
            instructor2.Background = "Yazılım geliştirme sürecine lise sonuncu sınıfta başladım.Sakarya Üniversitesi Yönetim Bilişim Sistemleri programından mezun oldum. Profesyonel iş hayatım üniversite 3. sınıfta başladı.\r\n\r\nKariyerime kodlama.io'da Yazılım Eğitmeni ve Danışmanı olarak devam ediyorum.Eğitim ve danışmanlık verdiğim kurumların bazıları; Esbaş, Etiya, KDK, Turkcell, Bosch. kodlama.io olarak geliştirdiğimiz \"nArch\" projesinde aktif geliştirici olarak rol almaktayım.";

        }
        public void Add(Instructor addInstructor)
        {
            instructors.Add(addInstructor);
            Console.WriteLine("Insturactor added.");

        }

        public List<Instructor> InsturactorGetAll()
        {
            return instructors;
            Console.WriteLine("Insturactor listed.");

        }

        public Instructor Read(int instrucatorId)
        {
            return instructors.Find(i=>i.Id==instrucatorId);
        }

        public void Remove(Instructor removenIstructor)
        {
            instructors.Remove(removenIstructor); 
            Console.WriteLine("Insturactor deleted.");

        }

        public void Update(Instructor updateInstructor)
        {
            Instructor existingInstructor = instructors.Find(instructors=>instructors.Id== updateInstructor.Id);
            if (existingInstructor != null) 
            {
                existingInstructor.FirstName = updateInstructor.FirstName;
                Console.WriteLine("Insturctor update.");

            }
            else
            {
                Console.WriteLine("Insturctor not found.");
            }
        }
    }
}
