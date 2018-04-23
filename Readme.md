# How to Cache Views in DXTabControl


<p>When views with heavy elements are displayed in a DXTabControl, it makes sense to cache them so that they are not recreated whenever a tab is opened. This will decrease loading time for cached tabs. DXTabControl supports several cache modes managed by the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfCoreDXTabControl_TabContentCacheModetopic">TabContentCacheMode</a> property:<br><br>- CacheAllTabs - all tabs are cached when DXTabControl is shown<br>- CacheTabsOnSelecting - tabs are cached only after selecting<br>- None - caching is disabled</p>

<br/>


