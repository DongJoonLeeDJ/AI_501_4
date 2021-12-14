
import numpy as np

np1 = np.arange(16).reshape(4,4)
print(np1)

np2 = np1 < 10
print(np2)

np1[np2] = 100
print(np1)