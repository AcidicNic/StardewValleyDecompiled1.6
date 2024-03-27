namespace StardewValley;

public class NPCDialogueResponse : Response
{
	public int friendshipChange;

	public string id;

	public string extraArgument;

	public NPCDialogueResponse(string id, int friendshipChange, string keyToNPCresponse, string responseText, string extraArgument = null)
		: base(keyToNPCresponse, responseText)
	{
		this.friendshipChange = friendshipChange;
		this.id = id;
		this.extraArgument = extraArgument;
	}
}
