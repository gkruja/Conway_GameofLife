#include <iostream>;

using namespace std;

int main()
{
	int ans = 0;
	cout << "Enter a even number: ";
	cin >> ans;
	ans = ans % 2;
	if (ans == 0)
	{
		cout << "you entered a even number! yay";
	}
	else
	{
		cout << "Enter a even number man";
	}




	system("pause");
	return 0;
}