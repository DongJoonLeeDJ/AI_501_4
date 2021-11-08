


class AA:
    def sum_all(self,alist):
        # print(alist)
        sum = 0
        for i in alist:
            sum += i
        return sum

    def reverse(self,alist):
        temp = []
        for i in range(len(alist)-1, -1, -1):
            temp.append(alist[i])
        return temp