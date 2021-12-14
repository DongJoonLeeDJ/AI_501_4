import numpy as np

np1 = np.random.randint(1,16, (4,4) )

# np1 = np.arange(16).reshape(4, 4)

print(np1)
print('열합계', np.sum(np1, axis=0))
print('행합계', np.sum(np1, axis=1))
