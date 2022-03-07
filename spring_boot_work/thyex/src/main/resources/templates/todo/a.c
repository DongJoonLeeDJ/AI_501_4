#include <stdio.h>

void main(){

    int bry[][] = {{1,2},{3,4},{5}};
    int ary[] = {1,2,3,4,5};
    int *a = ary;
    int *b = bry;

    int d = new int();
    // null;

    int *c = mallc(sizeof(4)*10);
    memset(c,0);
    printf("%d",*c);
    free(c);


    printf("%d",*(b+1));

    printf("%d",*a);
    printf("%d",*(a+1));
    printf("%d",*(a+2));
    printf("%d",*(a+3));

}