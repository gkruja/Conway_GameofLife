#include <iostream>;

using namespace std;

int main()
{
	cout << "Please enter a divisor";

	int div;
	cin >> div;
	int num;
	for (int i = 0; i < 3; i++)
	{
		num = rand();
		cout << num;
		if (num % 7 == 0)
		{
			cout << "  Yes\n";
		}
		else
		{
			cout << "No\n";
		}
	}

	system("pause");
	return 0;
}