#include <stdio.h>
#include <string.h>
#include <math.h>
char if_palidrom(char str[])
{
    int i;
    for(i = 0; i < strlen(str); i++)
        if(!(str[i] == str[abs(i-strlen(str))-1]))  {
            printf("nie jest palidromem");
            return 0;
        }
        else {
            printf("jest palidromem");
            return 0;
        }
}
int main(void)
{
    char str[40];

    printf("podaj slowo\n");
    scanf("%s",str);

    int i;
    for(i = 0; i <  strlen(str)+1; i++) {

        printf("%c\n",str[abs(i-strlen(str))]);
    }
    printf(if_palidrom(str));
}

