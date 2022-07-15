namespace Sort_Visual;

public partial class SortPage : ContentPage
{
	int numValues = 50;
	Values values = null;
	InsertionSort iSort =  null;
	SelectionSorter sSort = null;
	BubbleSorter bSort = null;

	public SortPage()
	{
		InitializeComponent();
		this.values = new Values(numValues, hsl);
		this.iSort = new InsertionSort(values, 100);
		this.sSort = new SelectionSorter(values, 50);
		this.bSort = new BubbleSorter(values, 50);

	}

	void GenerateValues(object sender, EventArgs args)
	{
		this.values.GenerateValues();
	}

	void InsertSort(object sender, EventArgs args)
	{
		iSort.Sort();
	}

    void BubbleSort(object sender, EventArgs args)
    {
        bSort.Sort();
    }
    void SelectSort(object sender, EventArgs args)
    {
        sSort.Sort();
    }

}