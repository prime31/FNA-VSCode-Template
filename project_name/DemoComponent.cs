using ImGuiNET;
using Nez;
using Nez.ImGuiTools;

namespace project_name
{
    public class DemoComponent : Component
    {
        int _ButtonClickCounter;

        public override void OnAddedToEntity()
        {
            // register with the ImGuiMangaer letting it know we want to render some IMGUI
            Core.GetGlobalManager<ImGuiManager>()?.RegisterDrawCommand(ImGuiDraw);
        }

        public override void OnRemovedFromEntity()
        {
            // remove ourselves when we are removed from the Scene
            Core.GetGlobalManager<ImGuiManager>()?.UnregisterDrawCommand(ImGuiDraw);
        }

        void ImGuiDraw()
        {
            // do your actual drawing here
            ImGui.Begin("Your ImGui Window", ImGuiWindowFlags.AlwaysAutoResize);
            ImGui.Text("This is being drawn in DemoComponent");
            if (ImGui.Button($"Clicked me {_ButtonClickCounter} times"))
                _ButtonClickCounter++;
            ImGui.End();
        }

    }
}

