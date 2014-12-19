// VCtest.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
#include "time.h"
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}




//void main123()
//{
//	clock_t start, finish;
//	double time;
//	int i, j, k;
//	int t[4600], a[4600], b[4600], c[4600], d[4600];
//	int na, nb, nc, nd;
//	int nna, nnb, nnc, nnd;
//	int n;
//	int min;
//	cout << "输入n:";
//	cin >> n;
//	start = clock();
//	for (i = 1; i <= 4500; i++)
//	{
//		t[i] = 0;
//		a[i] = 0;
//		b[i] = 0;
//		c[i] = 0;
//		d[i] = 0;
//	}
//	t[1] = 1;
//	a[1] = 2;
//	b[1] = 3;
//	c[1] = 5;
//	d[1] = 7;
//	na = 1; nb = 1; nc = 1; nd = 1;
//	nna = 1; nnb = 1; nnc = 1; nnd = 1;
//	i = 1;
//	while (i!=n)
//	{
//		i = i + 1;
//		nna = nna + 1;
//		nnb = nnb + 1;
//		nnc = nnc + 1;
//		nnd = nnd + 1;
//		if ((a[na] <= b[nb]) && (a[na] <= c[nc]) && (a[na] <= d[nd])) min = a[na];
//		if ((b[nb] <= a[na]) && (b[nb] <= c[nc]) && (b[nb] <= d[nd])) min = b[nb];
//		if ((c[nc] <= a[na]) && (c[nc] <= b[nb]) && (c[nc] <= d[nd])) min = c[nc];
//		if ((d[nd] <= a[na]) && (d[nd] <= b[nb]) && (d[nd] <= c[nc])) min = d[nd];
//		
//		a[nna] = min * 2;
//		b[nnb] = min * 3;
//		c[nnc] = min * 5;
//		d[nnd] = min * 7;
//		t[i] = min;
//
//		if (a[na] == min) na++;
//		if (b[nb] == min) nb++;
//		if (c[nc] == min) nc++;
//		if (d[nd] == min) nd++;
//
//	}
//	cout << t[i] << endl;
//	finish = clock();
//	time = (double) (finish - start) / CLOCKS_PER_SEC;
//	//cout << time;
//	printf("%.0f 毫秒\n", time * 1000);
//
//	getchar();
//	getchar();
//}

//class c_qiushihao
//{
//public:
//	bool 屌;
//	void 切屌()
//	{
//		屌 = false;
//	}
//};
//
//void main()
//{
//	c_qiushihao 邱世豪;
//	邱世豪.屌 = true;
//	cout << 邱世豪.屌 << endl;
//	邱世豪.切屌();
//	cout << 邱世豪.屌 << endl;
//	getchar();
//}


void main()
{
	clock_t start, finish;
	start = clock();



}