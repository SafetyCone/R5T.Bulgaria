using System;


namespace R5T.Bulgaria
{
    public static class Constants
    {
        /// <summary>
        /// The name of the Dropbox directory chosen by Dropbox (and created as part of the Dropbox installation process).
        /// </summary>
        /// <remarks>
        /// I was unsure of whether the Dropbox directory could be renamed (I know the location of the Dropbox directory can be changed, but that just creates a new directory called "Dropbox" in the chosen location), so I called it the default Dropbox directory name.
        /// </remarks>
        public const string DefaultDropboxDirectoryName = "Dropbox";
    }
}
