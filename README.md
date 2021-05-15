# rotX_Algorithm

Projekti i parë nga lënda "Siguria e të dhënave"

Ky projekt përmban implementimin e algoritmit ROTX përmes gjuhës programuese C#.

ROTX ("rrotullo(shifto) për X vende", është një algoritem i thjeshtë i zëvendësimit të shkronjave, që zëvendëson një shkronjë me shkronjën e X-të pas saj në alfabet.Vlerën e X-it e cakton përdoruesi dhe algoritmi punon ne varësi te asaj vlere.
Një ndër algoritmet e shpeshta ROTX është algoritmi në të cilin X=13.
ROT13 është një rast i veçantë i kodit së Cezarit i cili u zhvillua në Romën e lashtë.
Meqenëse ka 26 shkronja (2 × 13) në alfabetin bazë latin, ROT13 është anasjelltas i tij; domethënë, për të zhbërë ROT13, zbatohet i njëjti algoritëm, kështu që i njëjti veprim mund të përdoret për kodimin dhe dekodimin. Algoritmi nuk ofron praktikisht asnjë siguri kriptografike dhe shpesh citohet si një shembull kanonik i enkriptimit të dobët. 


# program.cs

Përshkrim i shkurtër rreth programit  dhe funksionit te tij:

Qëllimi i këtij programi është që të marrë një plaintext i cili përmes celësit kodohet dhe dekodohet.
Fillimisht është deklaruar dhe incializuar vektori që përmban 26 shkronjat e alfabetit latin.Pastaj në një variabël ruhet celësi.Përdoruesi e jep mesazhin në formë të teksit dhe celësin.Jepet mundësia që ta dekriptojë ose jo tekstin.Nëse përgjgjia është po, vazhdohet me dekriptim ,në të kundërtën dekriptimi nuk ndodh.

Metoda Console.Writeline():

Përdoret për te shfaqur mesazhe ose te dhëna në ekran .


Metoda Console.Readline():

Kjo metodë përdoret për të lexuar rreshtin e radhes së karaktereve nga inputi.
Ai vjen nën klasën e Console (System Namespace). 


Metoda Convert.ToInt32():

Konverton një vlerë specifike në një integer 32 bitësh.Në rastin tonë është përdorur për të bërë konvertimin e celësit nga string në integer.


Metoda append():

Kjo metodë shërben për të bashkangjitur një string në fund të objektit  aktual StringBuilder.Nëse StringBuilder nuk përmbanë ndonjeë string atëherë i shtohet stringu i cili caktohet përmes metodës append().
Në këtë program metoda append eshte përdorur në këtë formë:
# encryption.Append(plaintextArray[i]); 
Kjo e bën shtimin e anëtarëve të vektorit me radhë.


Metoda Equals():

Përcakton nëse dy instanca të objektit janë të barabarta.


Metoda Encryption:

Kodimi është procesi i vendosjes së një sekuence personazhesh (shkronja, numra, pikësim dhe simbole të caktuara) në një format të specializuar për transmetim ose ruajtje efikase. Në këtë rast enkodon tekstin në pozitat alfabetike të shkronjave.Kjo merr 2 parametra ne hyrje:celësin dhe plaintextin.
Rezultati i saj eshte teksti i enkriptuar.


Metoda Decryption:

Dekodimi është procesi i kundërt - shndërrimi i një formati të koduar përsëri në sekuencën origjinale të karaktereve.Ne kete rast dekodon vargun nga shifrat në shkronjat përkatëse.Metoda e kthen pergjigjien e dekriptuar e cila thirret ne main.


