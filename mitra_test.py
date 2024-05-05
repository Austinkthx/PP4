import matplotlib.pyplot as plt
import pandas as pd
import numpy as np
import seaborn as sns
import os

if __name__ == '__main__':
    data_dir = r"C:\Users\apaug\OneDrive\Desktop\DPL\DPL"
    file_name  = "___ExtractedPrices.csv"
    path = os.path.join(data_dir, file_name)
    df = pd.read_csv(path, encoding='unicode_escape')    
    df.info()
    
    sns.histplot(df)
    #plt.show()
    
    prices = df.iloc[:,0].value_counts()
    sns.barplot(x=prices.values,y=prices.index,orient='h')
    plt.show()
    
    
    
    
    
    