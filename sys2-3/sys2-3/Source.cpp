#include <iostream>;

using namespace std;

int main()
{
	int score = 0;
	char ans;
	cout << "Question 1: 'elseif' is a keyword in C++ : "; //true
	cin >> ans;
	ans = toupper(ans);

	if (ans == 'T')
	{
		cout << "Correct\n";
		score++;
	}
	else if (ans == 'F')
	{
		cout << "Wrong\n";
	}
	else
	{
		cout << "Invalid input\n";
	}
	cin.clear();
	
	cout << "Question 2 : Algorithms are usually written in any one specific language : "; // False
	cin >> ans;
	ans = toupper(ans);

	if (ans == 'F')
	{
		cout << "Correct\n";
		score++;
	}
	else if (ans == 'T')
	{
		cout << "Wrong\n";
	}
	else
	{
		cout << "Invalid input\n";
	}
	cin.clear();
	cout << "Question 3 : A switch's 'default' handles any unmatched values: "; //true
	cin >> ans;
	ans = toupper(ans);

	if (ans == 'T')
	{
		cout << "Correct\n";
		score++;
	}
	else if (ans == 'F')
	{
		cout << "Wrong\n";
	}
	else
	{
		cout << "Invalid input\n";
	}

	cout << "COngrats you finsihed and got " << score << " quations correct\n\n";


	system("pause");
	return 0;
}