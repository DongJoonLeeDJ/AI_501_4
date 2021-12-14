
import numpy as np

arr1 = np.arange(4).reshape(1,4)
arr2 = np.arange(8).reshape(2,4)

print(arr1)
print(arr2)

print()
arr3 = np.concatenate([arr1,arr2],axis=0)
print(arr3)

# print()
# arr4 = np.concatenate([arr1,arr2],axis=1)
# print(arr4)