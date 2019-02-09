//수열의 합 풀이1 sum=7+7+7+...+7 sum
#include<stdio.h>
#define NUM 10
int main() {
	int cnt = 1, sum=0;
	while (cnt <= NUM) {
		sum = sum + 7;
		printf("cnt=%d, sum=%d \n", cnt, sum);
		cnt++;
	}

	printf("-------------------------------------\n");
	printf("cnt=%d, sum=%d \n", cnt, sum);
	system("pause");
	return 0;
}
