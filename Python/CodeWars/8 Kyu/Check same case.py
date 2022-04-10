def same_case(a, b): 
    if a.isalpha() and b.isalpha():
        if a.islower() and b.islower() or a.isupper() and b.isupper():
            return 1
        elif a.islower() and b.isupper() or a.isupper() and b.islower():
            return 0
    else:
        return -1
