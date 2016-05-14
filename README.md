# FlappyBird

1. Опис на апликацијата
<hr>
	Апликацијата која ја креирав е играта FlappyBird. Оваа игра е едноставна и многу заразна.Главна цел е да се премине низ што е можно повеќе препреки за да се
	освојат што е можно повеќе поени. Поените се зголемуваат само доколку топчето премине низ препреката. Идејата ја земав од добро познатата игра FlappyBird.
 

2.Упатство за користење на играта
<hr>
	При стартување на играта се појавува почетен прозорец на кој може да се забележи топче кое се наоѓа на средината на формата. За да се започне со играње
	треба да се кликне(лев клик) на било кое место на формата. Со кликот започнува креирањето на препреките и нивно придвижување кон топчето. Дококолку се случи
	топчето да се удри во некоја од препреките играта се прекинува и се отвора нова форма во која се прикажува моменталниот број на поени како и најголемиот број на 
	поени постигнати во некоја претходна игра или моменталната доколку се надминати претходните најголемите поени. Освен освоените поени има и две копчиње од кои едното 
	овозможува започнување на нова игра и не враќа на почетниот прозорец а другото ни овозможува да ја напуштиме играта.  	
	
	
3. Претставување на проблемот
<hr>
	Главните податоци и функции се чуваат во класите: public class Bird, public class Stage и public class Obstruction.
	
	<img src"http://imgur.com/xyaMIrZ" alt="функција за придвижување на топчето">
	Во рамките на класата Bird во функцијата Move(int height) е овозможено придвижувањето на топчето нагоре доколку кликаме односно надолу во спротивен случај.
	Променливата height чија вредност се задава при повик на функцијата ни ја претставува висината на формата и ја користиме за да провериме дали птицата ја надминува 
	таа висина и доколку ја надминуа играта се прекинува и се отвора формата за приказ на поените.
	
	<img src"http://imgur.com/A4AMa2J" alt="функција за придвижување на топчето">
	Во рамките на класата Stage која ни претставува сцената врз која се исцртуваат препреките има неколку функции од кои една е и функцијата public void CalculatePoints()
	во која во циклус се изминуваат сите препреки и доколку топчето ја поминало препреката се зголемуваат поените и се поставува својството IsPassed на true за да не се 
	зголемуваат поените доколку препреката не е се уште избришана од public List<Obstruction> Obstructions { get; set;}.
	
	<img src"http://imgur.com/r6PXxJA" alt="функција за придвижување на топчето">
	Исто така друга поважна ф-ја во рамките на класата Stage е и функцијата public bool Collision() со која се одредува дали топчето дошло во допир со некоја од препреките
	за да се превземе соодветна акција во зависнот дали е допрена некоја препрека или не.
	
	