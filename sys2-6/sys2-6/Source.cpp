#include <iostream>;

using namespace std;

int main()
{
	cout << "Pick a quote ";
	int ans = -1;
	cin >> ans;

	switch (ans)
	{
	case 1:
	{
		break;
		cout << "you picked " <<  ans << "\n";
	}
	case 2:
	{
		cout << "you picked " << ans << "\n";
		break;
	}
	case 3:
	{
		cout << "you picked " << ans << "\n";
		break;
	}

	default:
		break;
	}




	system("pause");
	return 0;


}