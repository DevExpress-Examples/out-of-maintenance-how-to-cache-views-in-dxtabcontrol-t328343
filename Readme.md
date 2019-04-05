<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXTabControlExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXTabControlExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXTabControlExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXTabControlExample/MainWindow.xaml.vb))
* [TestWindow.xaml](./CS/DXTabControlExample/TestWindow.xaml) (VB: [TestWindow.xaml](./VB/DXTabControlExample/TestWindow.xaml))
* [TestWindow.xaml.cs](./CS/DXTabControlExample/TestWindow.xaml.cs) (VB: [TestWindow.xaml.vb](./VB/DXTabControlExample/TestWindow.xaml.vb))
<!-- default file list end -->
# How to Cache Views in DXTabControl


<p>When views with heavy elements are displayed in a DXTabControl, it makes sense to cache them so that they are not recreated whenever a tab is opened. This will decrease loading time for cached tabs. DXTabControl supports several cache modes managed by the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfCoreDXTabControl_TabContentCacheModetopic">TabContentCacheMode</a> property:<br><br>- CacheAllTabs - all tabs are cached when DXTabControl is shown<br>- CacheTabsOnSelecting - tabs are cached only after selecting<br>- None - caching is disabled</p>

<br/>


