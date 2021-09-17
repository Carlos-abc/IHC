/*

Input: nums = [8,1,2,2,3]
Output: [4,0,1,1,3]

*/

#include<stdio.h>

int main(){

    int vector[5] = {8,1,2,2,3};
    int vector2[5];
    int i;

    for(i=0; i<5; i++){


        vector2[i] = vector[i];

    }

    for(i=0; i<5; i++){

        printf(" %d ",vector[i]);

    }

    printf("\n");

    for(i=0; i<5; i++){

        printf(" %d ",vector2[i]);

    }
  
    
    

    

    

   
    
    
    

 

    


    return 0;
}