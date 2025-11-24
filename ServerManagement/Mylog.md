




<p>
	@* @status at @DateTime.Now *@
	@* @server.Name is in @server.City *@
	@* style="color:@(server.IsOnline?" green":"red")" *@
</p>

@* <ServerComponent></ServerComponent>
<br />
<ServerComponent></ServerComponent> *@

# log.md
@if(server != null)
    {

< p >
    @server.Name
</ p >

< p >
    @server.City
</ p >

< p >
    @server.IsOnline
</ p >
}
