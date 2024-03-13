Loto loto = new Loto();

int newSystemMinNumber = 1;
int newSystemMaxNumber = 90;
int newSystemSlotCount = 6;

int oldSystemMinNumber = 1;
int oldSystemMaxNumber = 49;
int oldSystemSlotCount = 6;

int matchCount = 4;

DateTime beginningTime = DateTime.Now;

var numbers = loto.generateLoteryNumbers(newSystemSlotCount, newSystemMinNumber, newSystemMaxNumber);
var newSystemWeekResults = loto.generateLoteryNumbers(newSystemSlotCount, newSystemMinNumber, newSystemMaxNumber);
Array.Sort(numbers);
Console.WriteLine(string.Join('-', numbers));

int newSystemMatchedCount = 0;
int newSystemTryCount = 0;

do
{
    newSystemWeekResults = loto.generateLoteryNumbers(newSystemSlotCount, newSystemMinNumber, newSystemMaxNumber);
    newSystemMatchedCount = loto.getMatchedCount(numbers, newSystemWeekResults);
    newSystemTryCount++;
}
while (newSystemMatchedCount < matchCount);

Console.WriteLine();
Array.Sort(newSystemWeekResults);
Console.WriteLine($"New:{newSystemTryCount.ToString("N0")} hafta sonra {string.Join('-', newSystemWeekResults)} numaraları çekildi. {newSystemMatchedCount} bildiniz!");

numbers = loto.generateLoteryNumbers(oldSystemSlotCount, oldSystemMinNumber, oldSystemMaxNumber);
var oldSystemWeekResults = loto.generateLoteryNumbers(oldSystemSlotCount, oldSystemMinNumber, oldSystemMaxNumber);
Array.Sort(numbers);
Console.WriteLine(string.Join('-', numbers));

int oldSystemMatchedCount = 0;
int oldSystemTryCount = 0;
do
{
    oldSystemWeekResults = loto.generateLoteryNumbers(oldSystemSlotCount, oldSystemMinNumber, oldSystemMaxNumber);
    oldSystemMatchedCount = loto.getMatchedCount(numbers, oldSystemWeekResults);

    oldSystemTryCount++;
}
while (oldSystemMatchedCount < matchCount);
Console.WriteLine();
Array.Sort(oldSystemWeekResults);
Console.WriteLine($"Old:{oldSystemTryCount.ToString("N0")} hafta sonra {string.Join('-', oldSystemWeekResults)} numaraları çekildi. {oldSystemMatchedCount} bildiniz!");


DateTime endTime = DateTime.Now;
var result = endTime - beginningTime;
var ms = result.TotalMilliseconds;
Console.WriteLine(ms);