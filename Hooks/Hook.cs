using mono_chat_client.Hooks;

namespace mono_chat_client
{
  internal class AwesomeHook
  {
    internal AwesomeHook()
    {
      advapi32.createRegOpenKeyExAHook();
      advapi32.createRegQueryValueExAHook();
      kernel32.createFindResourceAHook();
      user32.createMessageBoxWHook();
      wsock32.createConnectHook();
      wsock32.createRecvHook();
    }
  }
}
