# rotX_Algorithm

Projekti i parë nga lënda "Siguria e të dhënave"

Ky projekt përmban implementimin e algoritmit ROTX përmes gjuhës programuese C#.

ROTX ("rrotullo(shifto) për X vende", është një algoritëm i thjeshtë i zëvendësimit të shkronjave, që zëvendëson një shkronjë me shkronjën e X-të pas saj në alfabet.Vlerën e X-it e cakton përdoruesi dhe algoritmi punon në varësi të asaj vlere.
Një ndër algoritmet e shpeshta ROTX është algoritmi në të cilin X=13.
ROT13 është një rast i veçantë i kodit së Cezarit i cili u zhvillua në Romën e lashtë.
Meqenëse ka 26 shkronja (2 × 13) në alfabetin bazë latin, ROT13 është anasjelltas i tij; domethënë, për të zhbërë ROT13, zbatohet i njëjti algoritëm, kështu që i njëjti veprim mund të përdoret për kodimin dhe dekodimin. Algoritmi nuk ofron praktikisht asnjë siguri kriptografike dhe shpesh citohet si një shembull kanonik i enkriptimit të dobët. 

Udhëzimet për ekzekutimin e programit:

Ekzekutimi i programit bëhet prej Command Prompt duke i dhënë vlerat e argumenteve përkatëse, përkatësisht,kërkesat përkatëse. Varësisht prej vlerave ose të dhënave që i jepni, programi e kthen përgjigjien.


# program.cs

Përshkrim i shkurtër rreth programit  dhe funksionit të tij:

Qëllimi i këtij programi është që të marrë një plaintext i cili përmes celësit kodohet dhe dekodohet.
Fillimisht është deklaruar dhe incializuar vektori që përmban 26 shkronjat e alfabetit latin.Pastaj në një variabël ruhet celësi.Përdoruesi e jep mesazhin në formë të teksit dhe celësin.Jepet mundësia që ta dekriptojë ose jo tekstin.Nëse përgjgjia është po, vazhdohet me dekriptim ,në të kundërtën dekriptimi nuk ndodh.

Metoda Console.Writeline():

Përdoret për të shfaqur mesazhe ose të dhëna në ekran .


Metoda Console.Readline():

Kjo metodë përdoret për të lexuar rreshtin e radhës së karaktereve nga inputi.
Ajo vjen nën klasën e Console (System Namespace). 


Metoda Convert.ToInt32():

Konverton një vlerë specifike në një integer 32 bitësh.Në rastin tonë është përdorur për të bërë konvertimin e celësit nga string në integer.


Metoda append():

Kjo metodë shërben për të bashkangjitur një string në fund të objektit aktual StringBuilder.Nëse StringBuilder nuk përmbanë ndonjë string atëherë i shtohet stringu i cili caktohet përmes metodës append().
Në këtë program metoda append është përdorur në këtë formë:\
encryption.Append(plaintextArray[i])\
Kjo e bën shtimin e anëtarëve të vektorit me radhë.


Metoda Equals():

Përcakton nëse dy instanca të objektit janë të barabarta.


Metoda Encryption:

Kodimi është procesi i vendosjes së një sekuence personazhesh (shkronja, numra, pikësim dhe simbole të caktuara) në një format të specializuar për transmetim ose ruajtje efikase. Në këtë rast enkodon tekstin në pozitat alfabetike të shkronjave.Kjo metode merr 2 parametra ne hyrje:celësin dhe plaintextin.
Rezultati i saj eshte teksti i enkriptuar.


Metoda Decryption:

Dekodimi është procesi i kundërt - shndërrimi i një formati të koduar përsëri në sekuencën origjinale të karaktereve.Në këtë rast dekodon vargun nga shifrat në shkronjat përkatëse.Metoda e kthen përgjigjien e dekriptuar e cila thirret në main.


# form1.cs

Paraqet pjesen e dytë të projektit.Faktikisht pjesa e form është pjesa e desktop app e cila ke qenë e kërkuar te krijohet në kuadër të projektit.


◦Përshkrim rreth përmbajtjes dhe funksionit:

Kjo pjesë e programit paraqet ekzekutimin e kodit ne desktop.

# public partial class Form1 : Form

Duke përdorur klasën e pjesshme mundësohet që të definohet e njëjta klasë në dy source fajlla të ndryshëm që i përkasin së njëjtës namespace.Këto konsiderohen si të njëjta gjatë kompajlimit.Form1 është emri i Formës dhe ":" përdoret për të trashëguar vetitë e klasës bazë. Këtu Form përfaqëson System.Windows.Forms.Form. Trashëgimia përdoret për të hyrë në vetitë dhe metodat e klasës bazë.

Brenda Form1 gjenden:

1.textBox1_TextChanged()\
2.textBox2_TextChanged()\
3.textBox3_TextChanged()\
4.textBox4_TextChanged()

◦ button1_Click(object sender, EventArgs e)\
  Funksionon në këtë mënyrë:\
      ◦ Celësi  konvertohet në integer\
      ◦ Plaintexti në textbox-in e parë\
      ◦ Përmes celësit bëhet enkriptimi i plaintext-it

◦ button2_Click(object sender, EventArgs e)\
  Funksionon në këtë mënyrë:\
      ◦ Celësi  konvertohet në integer\
      ◦ Ciphertext-i në textboxin e tretë\
      ◦ Përmes celësit bëhet dekriptimi i ciphertext-it

◦ button3_Click(object sender, EventArgs e)\
  Në momentin që klikohet në këtë buton:\
      ◦ Fshihet përmbajtja e textBox1\
      ◦ Fshihet përmbajtja e textBox2\
      ◦ Fshihet përmbajtja e textBox3

◦ button4_Click(object sender, EventArgs e)\
  Pse është përdorur?\
       ◦ Kur na duhet të dalim ose të mbyllim formën e hapur atëherë duhet të përdorim metodën "this.Close ()" për të mbyllur formularin me rastin e klikimit të butonit.

Pjesa tjetër e kodit  është e ngjashme sikur në programin prapaprak.


# Form1.Designer.cs

Kjo pjesë ka të bëjë me dizajnin e desktop app (form1).\
Disa nga metodat e përdorura:

Dispose()

Dispose është një metodë që thirret për të ekzekutuar kodin e nevojshëm për pastrimin dhe lëshimin e memories dhe rivendosjen e burimeve të pakontrolluara, të tilla si lidhjet e bazës së të dhënave.Dispose() përmirëson performancën dhe optimizon kujtesën.

SuspendLayout()

Mundëson rregullimin e layout-it dhe shtimin psh.të butonave,label-ave textbox-ave.Pastaj bëhet edhe përcaktimi i madhësisë, vendndodhjes, tekstit brenda tyre etj.

System.EventHandler()

Përdoret për trajtimin e ngjarjeve. Psh kur klikohet butoni Encrypt, ndodh enkriptimi i plaintext-it.

this.Controls.Add()

Shton butonat, textbox-at etj , në varësi se qka shënojme brenda kllapave.

ResumeLayout()

Thirrja e metodës ResumeLayout bën të mundur që të paraqitet kërkesa në pritje nëse parametri është true, dhe në të kundërtën nuk paraqitet.

PerformLayout()

Kontrolli zbaton logjikën e paraqitjes së layout-it në të gjitha kontrollet fëmijë.

Referencat:

◦ https://www.w3schools.com/cs/

◦ https://www.geeksforgeeks.org/rot13-cipher/

◦ Ushtrimet dhe ligjëratat nga lënda Siguria e të dhënave.












