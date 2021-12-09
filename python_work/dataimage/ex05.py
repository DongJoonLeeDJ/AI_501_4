import numpy as np

arr1 = np.random.randint(1, 10, size=4)
print(arr1)

arr1 = arr1.reshape(2, 2) * 10
print(arr1)
